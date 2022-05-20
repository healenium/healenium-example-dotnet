using OpenQA.Selenium;

namespace Healenuim.Selenium.search.locators
{
    public class LinkTextStrategy : Strategy
    {
        private IWebDriver Driver;

        public LinkTextStrategy()
        {
        }

        public LinkTextStrategy(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool DoAction(string selector)
        {
            return Driver.FindElement(By.LinkText(selector)).Displayed;
        }
    }
}
