namespace Qimo.CCC.Lib {
    /// <summary>
    /// 请求数据父类
    /// </summary>
    /// <typeparam name="T">返回数据类型</typeparam>
    public class ApiRequest<T> where T : ApiResponse {

        /// <summary>
        /// 请求URL（不含开头的“/”）
        /// </summary>
        public string ApiUrl;

        /// <summary>
        /// 唯一字符串（可随机）
        /// 随机码，用户用来标识请求的操作，服务器返回的Response中会带有对应Action的ActionID；在通话事件中会带有该字段；该字段最大长度是40个字节
        /// 非必须
        /// </summary>
        public string ActionID { set; get; }

    }
}
