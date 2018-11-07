namespace Qimo.CCC.Lib {
    /// <summary>
    /// api请求客户端接口定义
    /// </summary>
    public interface IApiClient {

        /// <summary>
        /// 执行请求方法
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="request">请求数据</param>
        /// <returns></returns>
        T Execute<T>(ApiRequest<T> request) where T : ApiResponse;

    }
}
