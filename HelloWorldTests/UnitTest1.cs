using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = 1;
            var y = 2;
            Assert.AreNotEqual(x, y);
        }
    }
}
