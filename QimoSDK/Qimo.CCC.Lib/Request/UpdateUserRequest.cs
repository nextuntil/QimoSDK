using Qimo.CCC.Lib.Respose;

namespace Qimo.CCC.Lib.Request {
    /// <summary>
    /// 修改坐席接口请求数据
    /// 文档地址：https://developer.7moor.com/v2docs/updateUser/
    /// </summary>
    public class UpdateUserRequest:ApiRequest<UpdateUserResponse> {

        /// <summary>
        /// 坐席号,一般为8000,8001,8002等
        /// 必须
        /// </summary>
        public string exten { set; get; }

        /// <summary>
        /// 坐席姓名(需要修改时传此参数,传新值)
        /// </summary>
        public string displayName { set; get; }

        /// <summary>
        /// 邮箱(需要修改时传此参数,传新值)
        /// </summary>
        public string email { set; get; }

        /// <summary>
        /// 登录密码(需要修改时传此参数,传新值)
        /// </summary>
        public string password { set; get; }

        /// <summary>
        /// 手机号(需要修改时传此参数,传新值)
        /// </summary>
        public string mobile { set; get; }

    }
}
