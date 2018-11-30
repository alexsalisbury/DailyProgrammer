namespace EasyLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using EasyLibrary.Challenge369;

    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class HexColors_369_Tests
    {
        /// <summary>
        /// Tests from design post: https://www.reddit.com/r/dailyprogrammer/comments/a0lhxx/20181126_challenge_369_easy_hex_colors/
        /// </summary>
        [TestMethod]
        public void SmokeTests()
        {
            Assert.AreEqual("#FF6347", HexColors_369.ConvertToHex(255, 99, 71));
            Assert.AreEqual("#B8860B", HexColors_369.ConvertToHex(184, 134, 11));
            Assert.AreEqual("#BDB76B", HexColors_369.ConvertToHex(189, 183, 107));
            Assert.AreEqual("#0000CD", HexColors_369.ConvertToHex(0, 0, 205));
        }
    }
}