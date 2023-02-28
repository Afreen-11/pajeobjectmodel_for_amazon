using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pajeobjectmodel_for_amazon.pageobjectmodelforsaucedemo
{
    public class loginforsaucedemo
    {
        private readonly IWebDriver driver;

        private readonly By usernameField = By.Id("user-name");
        private readonly By passwordField = By.Id("password");
        private readonly By loginButton = By.Id("login-button");

        public loginforsaucedemo(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }

        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLoginButton();
        }
    }
}
