using Qimo.CCC.Lib.Common;

namespace Qimo.CCC.Lib {
    /// <summary>
    /// api返回数据父类
    /// </summary>
    public abstract class ApiResponse {

        /// <summary>
        /// json序列化
        /// </summary>
        /// <returns></returns>
        public string ToJson() {
            return JsonUtils.Serialize(this);
        }

    }
}
