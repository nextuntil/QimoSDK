using System;
using System.Collections.Generic;
using System.Text;

namespace Qimo.CCC.Lib.Respose {
    /// <summary>
    /// 查询坐席接口返回数据
    /// 文档地址：https://developer.7moor.com/v2docs/queryUser/
    /// </summary>
    public class GetCCAgentsByAccResponse : ApiResponse {

        /// <summary>
        /// 请求结果状态码
        /// </summary>
        public int code { set; get; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool success { get { return code == 200; } }

        /// <summary>
        /// 响应消息
        /// </summary>
        public string message { set; get; }

        /// <summary>
        /// 坐席数据列表
        /// </summary>
        public List<GetCCAgentsByAccResponse_Data_Item> data { set; get; }

    }

    /// <summary>
    /// 坐席数据列表项
    /// </summary>
    public class GetCCAgentsByAccResponse_Data_Item {

        /// <summary>
        /// 座席的ID
        /// </summary>
        public string _id { get; set; }

        /// <summary>
        /// 座席姓名
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        /// 座席工号
        /// </summary>
        public string exten { get; set; }

        /// <summary>
        /// 座席登录呼叫中心用户名，都与工号一致
        /// </summary>
        public string loginName { get; set; }

        /// <summary>
        /// 座席登录呼叫中心密码
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 座席所属的pbx
        /// </summary>
        public string pbx { get; set; }

        /// <summary>
        /// 座席绑定的手机
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 座席绑定的邮箱
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 座席状态，启用或者停用（enable/disable）
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 座席版本，标准版/外呼版/监控版（enterprise/outcall/monitor）
        /// </summary>
        public string uversion { get; set; }

        /// <summary>
        /// 座席外呼透传号，如果此字段没有，此座席外呼时使用，账号总透传号。可以用此字段关联座席与服务号关系
        /// </summary>
        public string callerIDNum { get; set; }

        /// <summary>
        /// 此座席拥有的角色
        /// </summary>
        public List<string> role { get; set; }

        /// <summary>
        /// 座席的上级座席ID
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// 后处理时长
        /// </summary>
        public string AutoBusyTime { get; set; }

        /// <summary>
        /// 是否为监控座席（agent/manager）
        /// </summary>
        public string type { get; set; }

    }

}
