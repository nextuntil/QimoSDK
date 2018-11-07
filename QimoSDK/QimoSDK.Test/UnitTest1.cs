using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qimo.CCC.Lib;
using Qimo.CCC.Lib.Request;
using Qimo.CCC.Lib.Respose;

namespace QimoSDK.Test {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            IApiClient client = new DefaultApiClient("http://apis.7moor.com", "xxxx", "xxxx");
            //ºô³ö
            CallDialoutRequest callDialoutRequest = new CallDialoutRequest("8002", "18888888888");
            CallDialoutResponse callDialoutResponse = client.Execute(callDialoutRequest);
            Assert.IsNull(callDialoutResponse);
        }
    }
}
