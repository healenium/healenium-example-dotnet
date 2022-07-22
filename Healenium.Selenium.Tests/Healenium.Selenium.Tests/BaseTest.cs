using System;
using Autofac;
using Healenium.Selenium.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Healenium.Selenium.Tests
{
    public class BaseTest
    {
        static protected IWebDriver _driver;
        public static ITestEnvPage _testEnvPage;
        public static ICallbackPage _callbackPage;
        public static IMainPage _mainPage;

        [SetUp]
        [Obsolete]
        public static void SetUp()
        {
            var optionsChrome = new ChromeOptions();
            optionsChrome.AddArguments("--no-sandbox");
            _driver = new RemoteWebDriver(new Uri("http://localhost:8085"), optionsChrome);

            //var options = new FirefoxOptions();
            //_driver = new RemoteWebDriver(new Uri("http://localhost:8085"), options);

            var builder = new ContainerBuilder();
            builder.Register(c => new TestEnvPage(_driver)).As<ITestEnvPage>();
            builder.Register(c => new CallbackTestPage(_driver)).As<ICallbackPage>();
            builder.Register(c => new MainPage(_driver)).As<IMainPage>();

            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                _testEnvPage = scope.Resolve<ITestEnvPage>();
                _callbackPage = scope.Resolve<ICallbackPage>();
                _mainPage = scope.Resolve<IMainPage>();
            }

        }

        [TearDown]
        public static void AfterAll()
        {
            _driver.Quit();
        }
    }
}

