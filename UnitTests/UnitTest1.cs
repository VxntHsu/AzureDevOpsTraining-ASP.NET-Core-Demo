using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var url = Environment.GetEnvironmentVariable("URL", EnvironmentVariableTarget.Process);
            Assert.AreEqual("https://study4.tw", url);
        }
    }
}