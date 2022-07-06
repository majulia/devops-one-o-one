using cicdExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cicdTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Helper.GetDescription(0), "COLD");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Helper.GetDescriptionToLower(0), "cold");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(Helper.GetDescription(-1), "FREEZING");
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(Helper.GetDescriptionToLower(-1), "freezing");
        }
    }
}
