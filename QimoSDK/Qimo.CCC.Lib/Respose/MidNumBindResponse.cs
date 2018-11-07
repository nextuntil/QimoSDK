namespace Qimo.CCC.Lib.Respose {
    /// <summary>
    /// 小号绑定（XB模式）接口返回数据
    /// 文档地址：https://developer.7moor.com/v2docs/rl_small/#1
    /// </summary>
    public class MidNumBindResponse : ApiResponse {
        /// <summary>
        /// 响应码
        /// </summary>
        public int Code { set; get; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get { return Code == 200; } }

        /// <summary>
        /// 响应信息
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// 绑定关系Id
        /// </summary>
        public string MappingId { set; get; }
    }
}
