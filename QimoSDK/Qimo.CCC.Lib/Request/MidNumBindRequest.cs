using Qimo.CCC.Lib.Respose;

namespace Qimo.CCC.Lib.Request {
    /// <summary>
    /// 小号绑定（XB模式）接口请求数据
    /// 文档地址：https://developer.7moor.com/v2docs/rl_small/#1
    /// </summary>
    public class MidNumBindRequest : ApiRequest<MidNumBindResponse> {

        /// <summary>
        /// 小号，必须为小号池中可用数据
        /// 必须
        /// </summary>
        public string midNum { set; get; }

        /// <summary>
        /// 被叫号码
        /// 必须
        /// </summary>
        public string called { set; get; }

        /// <summary>
        /// 被叫外显号码，"0"显真实号码 "1"显示中间号，默认 "1" 
        /// 非必须
        /// </summary>
        public string icDisplayFlag { set; get; }

        /// <summary>
        /// 是否需要录音，"true" 录音 "false" 不录音, 默认为”true”
        /// 非必须
        /// </summary>
        public string needRecord { set; get; }

        /// <summary>
        /// 自定义字段：会在账单和话单推送时回传回来
        /// 非必须
        /// </summary>
        public string userData { set; get; }

    }
}
