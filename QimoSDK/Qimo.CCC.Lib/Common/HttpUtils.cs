using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Qimo.CCC.Lib.Common {
    /// <summary>
    /// http工具类
    /// </summary>
    internal static class HttpUtils {

        /// <summary>
        /// 发起post请求
        /// </summary>
        /// <param name="requestUrl">请求URL</param>
        /// <param name="requestContentType">Content-Type</param>
        /// <param name="requestHeaders">请求头信息</param>
        /// <param name="requestData">请求参数</param>
        /// <param name="requestTimeoutSeconds">请求超时秒数</param>
        /// <returns></returns>
        internal static string Post(string requestUrl, string requestContentType = null, Dictionary<string, string> requestHeaders = null, string requestData = null, int? requestTimeoutSeconds = null) {
            string result = null;//请求结果
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(requestUrl);
            request.Method = "POST";
            request.Timeout = (requestTimeoutSeconds == null ? 10 : requestTimeoutSeconds.Value) * 1000;
            if (requestContentType != null) {
                request.ContentType = requestContentType;
            }
            if (requestHeaders != null && requestHeaders.Count > 0) {
                foreach (var item in requestHeaders) {
                    request.Headers.Add(item.Key, item.Value);
                }
            }
            try {
                if (!string.IsNullOrEmpty(requestData)) {
                    byte[] data = Encoding.UTF8.GetBytes(requestData);
                    request.ContentLength = data.Length;
                    using (Stream reqStream = request.GetRequestStream()) {
                        reqStream.Write(data, 0, data.Length);
                        reqStream.Close();
                    }
                }
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8)) {
                    result = reader.ReadToEnd();
                }
            } catch (Exception ex) {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 发起post请求
        /// </summary>
        /// <param name="requestUrl">请求URL</param>
        /// <param name="requestContentType">请求Content-Type</param>
        /// <param name="requestHeaders">请求头信息</param>
        /// <param name="requestParams">请求参数</param>
        /// <param name="requestTimeoutSeconds">请求超时秒数</param>
        /// <returns></returns>
        internal static string Post(string requestUrl, string requestContentType = null, Dictionary<string, string> requestHeaders = null, Dictionary<string, object> requestParams = null, int? requestTimeoutSeconds = null) {
            string requestData = null;
            if (requestParams != null && requestParams.Count > 0) {
                requestData = JsonUtils.Serialize(requestParams);
            }
            return Post(requestUrl, requestContentType, requestHeaders, requestData, requestTimeoutSeconds);
        }

    }
}
