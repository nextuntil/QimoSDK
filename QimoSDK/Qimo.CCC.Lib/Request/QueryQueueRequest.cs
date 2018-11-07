using Qimo.CCC.Lib.Respose;

namespace Qimo.CCC.Lib.Request {
    /// <summary>
    /// 查询通话技能信息组请求数据
    /// 文档地址：https://developer.7moor.com/v2docs/queryQueue/
    /// </summary>
    public class QueryQueueRequest:ApiRequest<QueryQueueResponse> {

        /// <summary>
        /// 该账户管理员登录用户中心所使用的密码
        /// </summary>
        public string password { set; get; }
    }
}
