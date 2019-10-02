using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            int[] result = new int[];
            Program.CheckConstain3(result,5,6);
            Assert.AreEqual(false, result);
        }
    }
}
