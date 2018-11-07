using Qimo.CCC.Lib.Respose;

namespace Qimo.CCC.Lib.Request {
    /// <summary>
    /// 查询坐席接口请求数据
    /// 文档地址：https://developer.7moor.com/v2docs/queryUser/
    /// </summary>
    public class GetCCAgentsByAccRequest:ApiRequest<GetCCAgentsByAccResponse> {

        /// <summary>
        /// 座席工号,一般为8000,8001,8002等
        /// 非必须
        /// </summary>
        public string Exten { set; get; }
    }
}
