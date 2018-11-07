namespace Qimo.CCC.Lib.Respose {
    /// <summary>
    /// 查询坐席状态返回数据
    /// 文档地址：https://developer.7moor.com/v2docs/queryUserState/
    /// </summary>
    public class QueryUserStateResponse:ApiResponse {

        /// <summary>
        /// 响应码（200：请求成功；210：坐席不存在；400：请求体参数错误；403：鉴权参数错误；500：服务器错误）
        /// </summary>
        public int Code { set; get; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get { return Code == 200; }  }

        /// <summary>
        /// 响应信息
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public QueryUserStateResponse_Data Data { set; get; }

    }

    /// <summary>
    /// 坐席状态数据
    /// </summary>
    public class QueryUserStateResponse_Data {

        /// <summary>
        /// 状态标记值（signout：签出；Reserve：离线接听；0：空闲；1：忙碌；2：小休；99：正在通话；3-9：自定义状态）
        /// </summary>
        public string Flag { set; get; }

        /// <summary>
        /// 状态
        /// </summary>
        public string State { set; get; }

    }

}
