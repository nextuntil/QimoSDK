﻿namespace Qimo.CCC.Lib.Respose {
    /// <summary>
    /// 挂机接口返回数据
    /// 文档地址：https://developer.7moor.com/v2docs/hangup/
    /// </summary>
    public class CallHangupResponse : ApiResponse {

        /// <summary>
        /// 请求是否成功
        /// </summary>
        public bool Succeed { set; get; }

        /// <summary>
        /// 对应Action的名称
        /// </summary>
        public string Response { set; get; }

        /// <summary>
        /// 对应操作的唯一标记
        /// </summary>
        public string ActionID { set; get; }

        /// <summary>
        /// 结果说明
        /// </summary>
        public string Message { set; get; }
    }
}
