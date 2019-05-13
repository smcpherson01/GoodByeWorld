using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoodbyeWorld; 

namespace GoodByeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Goodbye World!!", Program.createMessage());
        }
    }
}
