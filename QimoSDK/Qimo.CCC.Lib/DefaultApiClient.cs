using Qimo.CCC.Lib.Common;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Qimo.CCC.Lib {
    /// <summary>
    /// 默认的api请求客户端
    /// </summary>
    public class DefaultApiClient : IApiClient {

        #region 私有属性
        private string _baseUrl;
        private string _accountId;
        private string _apiSecret;
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="baseUrl">请求域名（不含最后的“/”）</param>
        /// <param name="accountId">帐号</param>
        /// <param name="apiSecret">帐号api secret</param>
        public DefaultApiClient(string baseUrl, string accountId, string apiSecret) {
            this._baseUrl = baseUrl;
            this._accountId = accountId;
            this._apiSecret = apiSecret;
        }
        #endregion

        #region 私有方法

        /// <summary>
        /// 生成授权数据
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        private string CreateAuthorization(string timeStamp) {
            return Utils.Base64(string.Format("{0}:{1}", this._accountId, timeStamp));
        }

        /// <summary>
        /// 生成签名数据
        /// </summary>
        /// <param name="timeStamp">时间戳</param>
        /// <returns></returns>
        private string CreateSignature(string timeStamp) {
            return Utils.MD5_32_Upper(string.Format("{0}{1}{2}", this._accountId, this._apiSecret, timeStamp));
        }

        /// <summary>
        /// 构建请求参数
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="request">请求数据对象</param>
        /// <returns></returns>
        private Dictionary<string, object> BuildParams<T>(ApiRequest<T> request) where T : ApiResponse {
            Dictionary<string, object> parameters = new Dictionary<string, object> { };
            Type t = request.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (PropertyInfo prop in props) {
                string pName = prop.Name;
                if (pName != "ApiUrl") {
                    object pValue = t.GetProperty(pName)?.GetValue(request);
                    if (!parameters.ContainsKey(pName) && !string.IsNullOrEmpty(pValue?.ToString())) {
                        parameters.Add(pName, pValue);
                    }
                }
            }
            return parameters;
        }

        #endregion

        #region 公共方法
        /// <summary>
        /// 请求api
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="request">请求数据</param>
        /// <returns></returns>
        public T Execute<T>(ApiRequest<T> request) where T : ApiResponse {
            try {
                //接口鉴权文档地址：https://developer.7moor.com/v2docs/authorization/  
                string timeStamp = Utils.GetTimeStamp();//时间戳
                string signature = CreateSignature(timeStamp);//签名
                string authorization = CreateAuthorization(timeStamp);//授权  
                string requestUrl = string.Format("{0}/{1}/{2}?sig={3}", this._baseUrl, request.ApiUrl, _accountId, signature); //请求URL
                string requestContentType = "application/json;charset=utf-8;";
                Dictionary<string, string> requestHeaders = new Dictionary<string, string> {
                    { "Authorization", authorization }
                };
                Dictionary<string, object> requestParams = BuildParams(request);//请求参数               
                string requestResult = HttpUtils.Post(requestUrl, requestContentType, requestHeaders, requestParams, 5);
                if (requestResult != null) {
                    return JsonUtils.Deserialize<T>(requestResult);
                }
                return null;
            } catch (Exception ex) {
                throw ex;
            }
        }
        #endregion
    }
}
