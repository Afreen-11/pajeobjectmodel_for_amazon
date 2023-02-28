using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace pajeobjectmodel_for_amazon.Baseclassforsaucedemo
{
    public class basetestforsaucedem
    {
        public IWebDriver driver;
        public ExtentReports extent;
        public  ExtentTest test;
        [SetUp]
        public void Setup()
        {
            // Initialize WebDriver
            driver = new ChromeDriver();

            // Initialize ExtentReports
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"D:\myworks\pajeobjectmodel_for_amazon\pajeobjectmodel_for_amazon\pageobjectmodelforsaucedemo\extentreport\SauceDemoTestReport.html");
            extent.AttachReporter(htmlReporter);

            // Create a new test
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }
        [TearDown]
        public void TearDown()
        {
            // Close the WebDriver
            driver.Quit();

            // End the test and generate the report
            extent.Flush();
        }

    }
}
