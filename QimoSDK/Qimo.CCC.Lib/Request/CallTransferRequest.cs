using Qimo.CCC.Lib.Respose;

namespace Qimo.CCC.Lib.Request {
    /// <summary>
    /// 转接接口请求数据
    /// 文档地址：https://developer.7moor.com/v2docs/transfer/
    /// </summary>
    public class CallTransferRequest:ApiRequest<CallTransferResponse> {

        /// <summary>
        /// 坐席工号
        /// 例：假设8001@gs是坐席登录账号，8001才是坐席工号
        /// 必须
        /// </summary>
        public string FromExten { set; get; }

        /// <summary>
        /// 被叫号码
        /// 可传入,外线号码, 坐席工号, 技能组编号例如:1501045xxxx, 8000, 10014640
        /// 必须
        /// </summary>
        public string Exten { set; get; }

        /// <summary>
        /// 转接到技能组为skillgroup, 转接到外线或者坐席为number
        /// 必须
        /// </summary>
        public string Mode { set; get; }

    }
}
