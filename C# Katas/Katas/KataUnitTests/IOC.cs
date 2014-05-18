using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataUnitTests
{
    [TestClass]
    public class IOCTests
    {
        [TestMethod]
        public void TestIOC()
        {

            var target = new Katas.IOC();

            Assert.AreEqual(target.ReturnPrintNames(), "Pan Powered");
        }
    }
}
