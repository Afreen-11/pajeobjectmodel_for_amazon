using OpenQA.Selenium;
using pajeobjectmodel_for_amazon.Baseclassforsaucedemo;
//using pajeobjectmodel_for_amazon.pageobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pajeobjectmodel_for_amazon.pageobjectmodelforsaucedemo.testscripts
{
    public class logintestforsaucedemo: basetestforsaucedem
    {
        [Test]
        public void TestLogin()
        {
            // Create a new LoginPage object
            var loginforsaucedemo = new loginforsaucedemo(driver);

            // Navigate to the login page
            loginforsaucedemo.NavigateToLoginPage();

            // Enter the username and password
            loginforsaucedemo.Login("standard_user", "secret_sauce");

            // Verify that the user has logged in successfully
            Assert.IsTrue(driver.Url.Contains("inventory.html"));
        }

    }
}
