using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace UnitTestProject2.NewFolder1
{
    public class IWebDriverUtilities
    {
        ExtentTest extentTest;
        public void ImplicitlyWait(IWebDriver driver, long time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        public void ExplicitWait(IWebDriver driver, long time)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));

            // wait.Until(ExpectedConditions.ElementIsVisible(By.Id("logoutLink")));
            wait.Until(ExpectedConditions.TitleContains("actiTIME - Enter Time-Track"));
        }

        public void MaximizeWindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }

        public static void ScreenShot(IWebDriver driver)
        {
            ITakesScreenshot takeScreenShot = (ITakesScreenshot)driver;

            Screenshot screenShot = takeScreenShot.GetScreenshot();
            BaseClass.screenShotPath = "C:\\Users\\panth\\source\\repos\\UnitTestProject2\\UnitTestProject2\\NewFolder1\\Screenshot\\screens.png";
            screenShot.SaveAsFile(BaseClass.screenShotPath, ScreenshotImageFormat.Png);
        }

    }
}
