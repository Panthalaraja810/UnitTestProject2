using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System;
using System.Windows;

namespace TestingTestContext
{
   // [TestClass]
    public class UnitTest1
    {
    static TestContext testContext;
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(testContext.Properties["webUrl"]);
            MessageBox.Show(testContext.Properties["webUrl"].ToString());        }
    }
}
