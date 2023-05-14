using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace UnitTestProject2
{
    [TestClass]
    public class BaseClass
    {
        public static IWebDriver driver; //declaring the webdriver, it should be static and should be only one present in base class

        public static ExtentReports extentReports; //declaring the extent report, it should be static
       
        public static ExtentHtmlReporter extentHtmlReporter; //declaring the extenthtml report, it should be static
        public static String screenShotPath;  //declaring the screenshot path

        public TestContext testContext;
        public ExtentTest extentTest;
        public static String testResultPath = "C:\\Users\\panth\\source\\repos\\UnitTestProject2\\UnitTestProject2\\NewFolder1\\Report\\";

        //  String fPath = "C:\\Users\\panth\\source\\repos\\UnitTestProject2\\UnitTestProject2\\NewFolder1\\Excel1.xlsx";

       // public String url;

        public TestContext Test
        {
            get { return testContext; }
            set { testContext = value; }
        }


        [AssemblyInitialize]
        public static void InitializeAssembly(TestContext testContext)
        {
            extentReports = new ExtentReports();
            extentHtmlReporter = new ExtentHtmlReporter(testResultPath);
            extentHtmlReporter.Start();
            extentReports.AttachReporter(extentHtmlReporter);
        }


        [AssemblyCleanup]
        public static void CleanupAssembly()
        {
            extentReports.Flush();
            extentHtmlReporter.Stop();
        }

        [TestInitialize]
        public void InitializaTest() //test initializer method
        {
            //opening the browser
            driver = new ChromeDriver();

        }

        [TestCleanup]
        public void TestCleanupMethod()
        {
            driver.Quit(); //closing the browser
            driver.Dispose(); //clean
                              //invalid arguments
        }

      
        /*
         [AssemblyInitialize]
        public void AssemblyInit()
        {
            Console.WriteLine("Initialize Assembly 2");
        }

        [AssemblyCleanup]
        public void AssemblyClean()
        {
            Console.WriteLine("Cleanup Assembly 2");
        }

        [ClassInitialize]
        public static void InitialClass()
        {
            Console.WriteLine("Class Initialize 2");
        }

        [ClassCleanup]
        public static void CleanClass()
        {
            Console.WriteLine("Class CleanUp 2");
        }
        */








    }
}
