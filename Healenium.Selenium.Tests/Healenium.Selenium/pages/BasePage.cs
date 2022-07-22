using System;
using OpenQA.Selenium;

namespace Healenium.Selenium.pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}

