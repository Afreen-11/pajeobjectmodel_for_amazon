using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pajeobjectmodel_for_amazon.extentreportsfolder
{
    public class extentreport1
    {

        private IWebDriver driver;
        private ExtentReports extent;
        private ExtentTest test;

        [OneTimeSetUp]
        public void BeforeClass()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"D:\myworks\pajeobjectmodel_for_amazon\pajeobjectmodel_for_amazon\extentreportsfolder\extentreport1.html");
            extent.AttachReporter(htmlReporter);
        }

        [SetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver();
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestMethod()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            test.Log(Status.Info, "Navigated to Google");
            test.Pass("Test Passed");
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }

        [OneTimeTearDown]
        public void AfterClass()
        {
            extent.Flush();
        }
    }
}
