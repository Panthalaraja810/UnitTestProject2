using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Net.NetworkInformation;

namespace UnitTestProject2.NewFolder1
{
    public class LoginPageElements
    {
        //DECLARATION
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement username { get; set; }

        [FindsBy(How = How.Name, Using = "pwd")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.ClassName, Using = "initial")]
        private IWebElement loginBtn { get; set; }

        //initialization
        public LoginPageElements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        //utilization
        public void Login(string Username, string Password)
        {
            username.SendKeys(Username);
            password.SendKeys(Password);
            loginBtn.Click();
        }
    }
}
