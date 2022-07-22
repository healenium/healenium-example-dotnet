using System;
using OpenQA.Selenium;

namespace Healenium.Selenium.search.locators
{
    public class TagStrategy : Strategy
    {
        private IWebDriver Driver;

        public TagStrategy()
        {
        }

        public TagStrategy(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool DoAction(string selector)
        {
            return Driver.FindElement(By.TagName(selector)).Displayed;
        }
    }
}

