using System;
using OpenQA.Selenium;

namespace Healenium.Selenium.search.locators
{
    public class XPathStrategy : Strategy
    {
        private IWebDriver Driver;

        public XPathStrategy()
        {
        }

        public XPathStrategy(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool DoAction(string selector)
        {
            return Driver.FindElement(By.XPath(selector)).Displayed;
        }
    }
}

