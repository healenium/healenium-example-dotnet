using OpenQA.Selenium;

namespace Healenuim.Selenium.search.locators
{
    public class CssStrategy : Strategy
    {
        private IWebDriver Driver;

        public CssStrategy()
        {
        }

        public CssStrategy(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool DoAction(string selector)
        {
            return Driver.FindElement(By.CssSelector(selector)).Displayed;
        }
    }
}
