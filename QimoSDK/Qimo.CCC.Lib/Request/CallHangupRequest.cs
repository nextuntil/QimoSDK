using Qimo.CCC.Lib.Respose;

namespace Qimo.CCC.Lib.Request {
    /// <summary>
    /// 挂机接口请求数据
    /// 文档地址：https://developer.7moor.com/v2docs/hangup/
    /// </summary>
    public class CallHangupRequest : ApiRequest<CallHangupResponse> {

        #region 构造函数

        /// <summary>
        /// 挂机接口请求数据默认构造函数
        /// </summary>
        public CallHangupRequest() { }

        /// <summary>
        /// 挂机接口请求数据带参构造函数
        /// </summary>
        /// <param name="callID">通话ID</param>
        /// <param name="agent">坐席工号</param>
        public CallHangupRequest(string callID = null, string agent = null) {
            ApiUrl = "v20160818/call/hangup";
            CallID = callID;
            Agent = agent;
        }

        #endregion

        #region 属性

        /// <summary>
        /// 通话ID，CallID和Agent必须一项，优先使用CallID
        /// 这个CallID一般都是由通话事件推送获取到的。可以关注link事件，这个参数会在电话接通时抛出来
        /// </summary>
        public string CallID { set; get; }

        /// <summary>
        /// 坐席工号，CallID和Agent必须一项，优先使用CallID
        /// 如8000，8001，8002等
        /// </summary>
        public string Agent { set; get; }

        #endregion

    }
}
