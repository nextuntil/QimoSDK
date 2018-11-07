using Newtonsoft.Json;

namespace Qimo.CCC.Lib.Common {
    /// <summary>
    /// json工具类
    /// </summary>
    internal static class JsonUtils {

        /// <summary>
        /// json序列化
        /// </summary>
        /// <param name="obj">待序列化的对象</param>
        /// <returns></returns>
        internal static string Serialize(object obj) {
            if (obj != null) {
                return JsonConvert.SerializeObject(obj);
            }
            return null;
        }

        /// <summary>
        /// json反序列化
        /// </summary>
        /// <typeparam name="T">反序列化对象类型</typeparam>
        /// <param name="json">待反序列化的json字符串</param>
        /// <returns></returns>
        internal static T Deserialize<T>(string json) {
            if (!string.IsNullOrEmpty(json)) {
                return JsonConvert.DeserializeObject<T>(json);
            }
            return default(T);
        }

    }
}
