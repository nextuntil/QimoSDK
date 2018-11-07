namespace Qimo.CCC.Lib.Respose {
    /// <summary>
    /// 修改坐席接口返回数据
    /// 文档地址：https://developer.7moor.com/v2docs/updateUser/
    /// </summary>
    public class UpdateUserResponse:ApiResponse {
        /// <summary>
        /// 响应码（200：请求成功；210：坐席不存在；400：请求体参数错误；403：鉴权参数错误；500：服务器错误）
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
    }
}
