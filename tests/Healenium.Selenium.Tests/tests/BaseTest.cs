using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace Healenium.Selenium.Tests.tests
{
    public class BaseTest
    {
        static protected IWebDriver _driver;

        [SetUp]
        [Obsolete]
        public static void SetUp()
        {
            var optionsChrome = new ChromeOptions();
            optionsChrome.AddArguments("--no-sandbox");
            _driver = new RemoteWebDriver(new Uri("http://localhost:8085"), optionsChrome);

            //var options = new FirefoxOptions();
            //_driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub/"), options);
        }

        [TearDown]
        public static void AfterAll()
        {
            _driver.Quit();
        }
    }
}
