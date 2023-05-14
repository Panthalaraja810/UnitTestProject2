using AventStack.ExtentReports;
using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using System;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Xml.Linq;

namespace UnitTestProject2.NewFolder1
{
  // [TestClass]
    public class TestScript : BaseClass
    {
      //  public XRef:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;
        excelUtility excel =new excelUtility();
        IWebDriverUtilities webDriverUtilities = new IWebDriverUtilities();

        String url;

        [TestMethod]
        [TestCategory("Parameters")]
        [DataTestMethod]
        public void DataRowAndDataDriven()
        {

            // System.Collections.Generic.IEnumerable<object>


            //var url = Test.Properties["WebUrl"].ToString();
            // Console.WriteLine(url);

            // var doc = XDocument.Load("C:\\Users\\panth\\source\\repos\\UnitTestProject2\\UnitTestProject2\\settings.runsettings");
            //  string url  = (string)doc.Element("settings").Element("webUrl");


         var ul=   Test.Properties["WebUrl"];

           var url = Convert.ToString(ul);
           // messagebo.Show(url);

            /*  try
                {
                    var url = Test.Properties["webAppUrl"].ToString();
                }
                catch(Exception ex) 
                {

                    Console.WriteLine(url);

                }

                if(url != null)
                {
                      driver.Navigate().GoToUrl(url);

                }
                else
                {
                    Console.WriteLine("null value");
                }
            */
            //        url = Test.Properties["WebUrl"].ToString() ;
            //   eTitle = Test.Properties["WebTitle"].ToString() ;

            //   url = (System.Collections.Generic.IEnumerable<object>)testContext.Properties["WebUrl"];
            //  eTitle = (string)testContext.Properties["WebTitle"];

            //    url = (string)Test.Properties["WebUrl"];
            //  driver.Url = url;

            //   eTitle = Test.Properties["WebTitle"];

            //  eTitle = excel.data("Sheet1");

            var eTitle =  excel.data(1);
            Console.WriteLine(eTitle);

            // Console.WriteLine(Test.Properties(Url);
            //  string _appUrl = Test.Properties["Url"];

            //  driver.Url = url;

            //  driver.Navigate().GoToUrl(url) ;

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
