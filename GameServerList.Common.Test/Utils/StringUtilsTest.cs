using GameServerList.Common.Utils;

namespace GameServerList.Common.Test.Utils
{
    [TestClass]
    public sealed class StringUtilsTest
    {
        [TestMethod]
        public void TestTruncate()
        {
            Assert.AreEqual("", StringUtils.Truncate(null, 0));
            Assert.AreEqual("…", StringUtils.Truncate(" ", 0));
            Assert.AreEqual("", StringUtils.Truncate("", 0));
            Assert.AreEqual("…", StringUtils.Truncate("hello", 0));
            Assert.AreEqual("he…", StringUtils.Truncate("hello", 2));
        }
    }
}
