using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;

namespace UnitTestProject2.NewFolder1
{
    [TestClass]
    public class UnitTest1 : BaseClass
    {
        excelUtility excel = new excelUtility();
        IWebDriverUtilities webDriverUtilities = new IWebDriverUtilities();

        [TestMethod]
        public void TestMethod1()
        {

            var ul = testContext.Properties["WebUrl"];

            var url = ul.ToString();
            Console.WriteLine("");

            driver.Url = url;

            var eTitle = excel.data(1);
            Console.WriteLine(eTitle);

            webDriverUtilities.ImplicitlyWait(driver, 10);
            String aTitle = driver.Title;
            extentTest = extentReports.CreateTest(url + "Test");
            extentTest.Info(url + aTitle);
            Console.WriteLine(aTitle);
            Console.WriteLine(eTitle);
            try
            {
                Assert.AreEqual(eTitle, aTitle);
                extentTest.Pass("passed");
            }
            catch (Exception e)
            {
                extentTest.Fail("failed");
                extentTest.Info(e);
                IWebDriverUtilities.ScreenShot(driver);
                extentTest.AddScreenCaptureFromPath(screenShotPath);
            }

        }

    }

}
