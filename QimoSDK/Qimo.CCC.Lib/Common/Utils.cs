using System;
using System.Security.Cryptography;
using System.Text;

namespace Qimo.CCC.Lib.Common {
    /// <summary>
    /// 工具类
    /// </summary>
    internal static class Utils {

        /// <summary>
        /// 获取时间戳
        /// 非常规意义上的时间戳，仅为七陌API请求所需的时间戳
        /// 时间戳是当前系统时间,格式"yyyyMMddHHmmss"。时间戳是24小时制,如：20140416142030
        /// </summary>
        /// <returns></returns>
        internal static string GetTimeStamp() {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        /// <summary>
        /// 对字符串进行BASE64编码
        /// </summary>
        /// <param name="str">待编码字符串</param>
        /// <returns></returns>
        internal static string Base64(string str) {
            string result = "";
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            try {
                result = Convert.ToBase64String(bytes);
            } catch {
                result = str;
            }
            return result;
        }

        /// <summary>
        /// 对字符串进行MD5加密（32位，大写）
        /// </summary>
        /// <param name="str">待加密字符串</param>
        /// <returns></returns>
        internal static string MD5_32_Upper(string str) {
            string result = "";
            MD5CryptoServiceProvider m5 = new MD5CryptoServiceProvider();
            //创建md5对象
            byte[] inputBye;
            byte[] outputBye;
            //使用GB2312编码方式把字符串转化为字节数组．
            try {
                inputBye = Encoding.UTF8.GetBytes(str);
            } catch {
                inputBye = Encoding.GetEncoding("GB2312").GetBytes(str);
            }
            outputBye = m5.ComputeHash(inputBye);
            result = BitConverter.ToString(outputBye);
            result = result.Replace("-", "").ToUpper();
            return result;
        }

    }
}
