using Qimo.CCC.Lib.Respose;

namespace Qimo.CCC.Lib.Request {
    /// <summary>
    /// 外呼接口请求数据
    /// 文档地址：https://developer.7moor.com/v2docs/dialout/
    /// </summary>
    public class CallDialoutRequest : ApiRequest<CallDialoutResponse> {

        #region 构造函数

        /// <summary>
        /// 外呼接口请求数据默认构造函数
        /// </summary>
        public CallDialoutRequest() {
           
        }

        /// <summary>
        /// 外呼接口请求数据带参构造函数
        /// </summary>
        /// <param name="fromExten">坐席工号</param>
        /// <param name="exten">被叫号码</param>
        /// <param name="extenType">接听方式</param>
        /// <param name="dialoutStrVar">自定义参数（JSON格式）</param>
        public CallDialoutRequest(string fromExten, string exten, string extenType = null, string dialoutStrVar = null) {
            ApiUrl = "v20160818/call/dialout";
            FromExten = fromExten;
            Exten = exten;
            ExtenType = extenType;
            DialoutStrVar = dialoutStrVar;
        }

        #endregion

        #region 属性

        /// <summary>
        /// 坐席工号
        /// 例：假设8001@gs是坐席登录账号，8001才是坐席工号
        /// 必须
        /// </summary>
        public string FromExten { set; get; }

        /// <summary>
        /// 被叫手机号
        /// 被叫号码；对于手机号，系统会自动判断是否本地号码，从而自动在号码前加0，使用者不需要处理，只需传手机号即可，如138********。对于固话，如果是外地号码使用者需要将区号带上，如010********
        /// 必须
        /// </summary>
        public string Exten { set; get; }

        /// <summary>
        /// 外呼时强制坐席使用该接听方式
        /// 正常情况下调用外呼接口不需传此字段，座席默认使用登录呼叫中心的接听方式外呼。如有特殊需要，例如：座席不登录系统发起外呼，需要传此字段。Local为“手机”sip为“软电话”gateway为“语音网关”
        /// 值：Local/sip/gateway
        /// 非必须
        /// </summary>
        public string ExtenType { set; get; }

        /// <summary>
        /// 外呼自定义参数
        /// 用户可在此字段中自定义参数，在事件推送中会推送该字段，支持推送json格式的参数如DialoutStrVar={ "name": "John" }
        /// 非必须
        /// </summary>
        public string DialoutStrVar { set; get; }

        #endregion
    }
}
