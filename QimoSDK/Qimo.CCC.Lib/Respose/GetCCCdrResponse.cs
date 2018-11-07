using System.Collections.Generic;

namespace Qimo.CCC.Lib.Respose {
    /// <summary>
    /// 查询通话记录接口返回数据
    /// 文档地址：https://developer.7moor.com/v2docs/queryCdr-2/
    /// </summary>
    public class GetCCCdrResponse : ApiResponse {

        /// <summary>
        /// 请求结果状态码（403：鉴权失败；400：鉴权成功，业务失败；200：鉴权成功，业务成功）
        /// </summary>
        public int Code { set; get; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { set; get; }

        /// <summary>
        /// 响应消息
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public List<GetCCCdrResponse_Data_Item> Data { set; get; }

    }

    /// <summary>
    /// 通话记录列表项
    /// </summary>
    public class GetCCCdrResponse_Data_Item {

        /// <summary>
        /// 本条通话记录的唯一ID
        /// </summary>
        public string _id { get; set; }

        /// <summary>
        /// 本条通话记录的唯一ID（与_id值一致）
        /// </summary>
        public string CALL_SHEET_ID { get; set; }

        /// <summary>
        /// 主叫号码
        /// </summary>
        public string CALL_NO { get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        public string CALLED_NO { get; set; }

        /// <summary>
        /// 通话ID
        /// </summary>
        public string CALL_ID { set; get; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string END_TIME { get; set; }

        /// <summary>
        /// 呼叫类型，值为 normal（普通来电）、dialout（外呼去 电）、transfer（来电转接）、dialTransfer（外呼转接）
        /// </summary>
        public string CONNECT_TYPE { get; set; }

        /// <summary>
        /// 处理状态，值为dealing（已接听）、notDeal（振铃未接 听）、queueLeak（排队放弃）、voicemail（已留言）、 leak（IVR放弃） 、blackList（黑名单）
        /// </summary>
        public string STATUS { get; set; }

        /// <summary>
        /// 处理座席工号
        /// </summary>
        public string EXTEN { set; get; }

        /// <summary>
        /// 处理座席ID（历史原因创建的字段，如无用处可无视）
        /// </summary>
        public string DISPOSAL_AGENT { get; set; }

        /// <summary>
        /// 通话开始时间（只有已接听状态的才有值）
        /// </summary>
        public string BEGIN_TIME { get; set; }

        /// <summary>
        /// 呼叫发起时间
        /// </summary>
        public string OFFERING_TIME { get; set; }

        /// <summary>
        /// 录音文件名
        /// </summary>
        public string RECORD_FILE_NAME { get; set; }

        /// <summary>
        /// 定位客户名称
        /// </summary>
        public string CUSTOMER_NAME { get; set; }

        /// <summary>
        /// 转接类型通话，此字段记录之前一通通话记录的ID
        /// </summary>
        public string REF_CALL_SHEET_ID { get; set; }

        /// <summary>
        /// 通话产生所在PBX的ID
        /// </summary>
        public string PBX { get; set; }

        /// <summary>
        /// 技能组名称
        /// </summary>
        public string QUEUE_NAME { get; set; }

        /// <summary>
        /// 录音服务器地址
        /// </summary>
        public string FILE_SERVER { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string PROVINCE { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string DISTRICT { get; set; }

        /// <summary>
        /// 城市区号
        /// </summary>
        public string DISTRICT_CODE { get; set; }

        /// <summary>
        /// 是否标记
        /// </summary>
        public bool KEY_TAG { set; get; }

        /// <summary>
        /// 通话时长（未接通为0）
        /// </summary>
        public int CALL_TIME_LENGTH { get; set; }

        /// <summary>
        /// 满意度调查
        /// </summary>
        public string INVESTIGATE { set; get; }

        /// <summary>
        /// 该值为调用外呼接口时，传的ActionID
        /// </summary>
        public string ACTION_ID { set; get; }
    }
}
