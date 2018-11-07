using System.Collections.Generic;

namespace Qimo.CCC.Lib.Respose {
    /// <summary>
    /// 查询通话技能信息组返回数据
    /// 文档地址：https://developer.7moor.com/v2docs/queryQueue/
    /// </summary>
    public class QueryQueueResponse : ApiResponse {
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

        /// <summary>
        /// 返回数据
        /// </summary>
        public List<QueryQueueResponse_Data> Data { set; get; }
    }

    /// <summary>
    /// 通话技能组数据
    /// </summary>
    public class QueryQueueResponse_Data {

        /// <summary>
        /// 技能组的名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 技能组的接听策略 rrmemory-轮流，random-随机，fewestcalls-接听最少
        /// </summary>
        public string Strategy { get; set; }

        /// <summary>
        /// 是否启用报工号
        /// </summary>
        public string SayExten { get; set; }

        /// <summary>
        /// 无空闲座席立即流转 1 是 0 否
        /// </summary>
        public string JoinEmpty { get; set; }

        /// <summary>
        /// 来电弹屏对接id，为空则弹系统默认屏
        /// </summary>
        public string BussinessTypeId { get; set; }

        /// <summary>
        /// 等待时长
        /// </summary>
        public string WaitTime { get; set; }

        /// <summary>
        /// 振铃时长
        /// </summary>
        public string Timeout { get; set; }

        /// <summary>
        /// 技能组为空时转向:
        /// system-系统节点
        /// ivr_node_queue 技能组
        /// account_user 坐席
        /// ivr_node_announcement 播放语音节点
        /// ivr_node_text_announcement 播放文本语音节点
        /// ivr_node_ivr 按键菜单节点
        /// ivr_node_encrypt_md5 MD5 加密节点
        /// ivr_node_validation 采集输入节点
        /// ivr_node_assignment 赋值节点
        /// ivr_node_route 按变量路由节点
        /// ivr_node_ivr_menu 转 ivr 菜单节点
        /// ivr_node_call_url calurl 节点
        /// ivr_node_voice_mail 留言节点
        /// ivr_node_room 会议室节点
        /// ivr_node_satisfaction 自定义满意度节点
        /// ivr_node_superDialJobNum 采样工号并拨打节点
        /// ivr_node_extension_peer 自定义节点
        /// </summary>
        public string ToPeerTypeWhenQueueEmpty { get; set; }

        /// <summary>
        /// 具体的节点操作 ID 例如 system 中 0-挂机，1 满意度调 查，2-拨工号
        /// </summary>
        public string ToPeerWhenQueueEmpty { get; set; }

        /// <summary>
        /// 正在等待时转向:取值同 ToPeerTypeWhenQueueEmpty
        /// </summary>
        public string ToPeerTypeWhenWait { get; set; }

        /// <summary>
        /// 具体的节点操作 ID 例如 system 中 0-挂机，1 满意度调 查，2-拨工号
        /// </summary>
        public string ToPeerWhenWait { get; set; }

        /// <summary>
        /// 等待超时转向:取值同 ToPeerTypeWhenQueueEmpty
        /// </summary>
        public string ToPeerTypeWhenWaitTimeout { get; set; }

        /// <summary>
        /// 具体的节点操作 ID 例如 system 中 0-挂机，1 满意度调 查，2-拨工号
        /// </summary>
        public string ToPeerWhenWaitTimeout { get; set; }

        /// <summary>
        /// 通话结束后转向:取值同 ToPeerTypeWhenQueueEmpty
        /// </summary>
        public string ToPeerTypeWhenHanguped { get; set; }

        /// <summary>
        /// 具体的节点操作 ID 例如 system 中 0-挂机，1 满意度调 查，2-拨工号
        /// </summary>
        public string ToPeerWhenHanguped { get; set; }

        /// <summary>
        /// 账户 ID 和调用接口所传 AccountId 一致
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// PBX
        /// </summary>
        public string PBX { get; set; }

        /// <summary>
        /// 技能组号
        /// </summary>
        public string Exten { get; set; }

        /// <summary>
        /// 坐席列表
        /// </summary>
        public List<QueryQueueResponse_Data_AssignMembersItem> AssignMembers { get; set; }

        /// <summary>
        /// 分配的坐席的 ID 字串 (不用返回)
        /// </summary>
        public string Members { get; set; }

        /// <summary>
        /// 技能组信息更新时间
        /// </summary>
        public string UpdateTime { get; set; }

        /// <summary>
        /// 是否启用报工号后的提示音
        /// </summary>
        public string AgentExtenPoint { get; set; }

        /// <summary>
        /// 播报排队位置时间间隔
        /// </summary>
        public string SayQueuePosition { get; set; }
    }

    /// <summary>
    /// 坐席信息
    /// </summary>
    public class QueryQueueResponse_Data_AssignMembersItem {

        /// <summary>
        /// 已经分配的坐席 Id
        /// </summary>
        public string agentID { get; set; }

        /// <summary>
        /// 坐席优先级
        /// </summary>
        public string penalty { get; set; }

        /// <summary>
        /// 坐席工号
        /// </summary>
        public string agentExten { get; set; }

        /// <summary>
        /// 坐席名称
        /// </summary>
        public string agentName { get; set; }
    }

}
