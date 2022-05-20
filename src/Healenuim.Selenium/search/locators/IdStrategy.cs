using OpenQA.Selenium;

namespace Healenuim.Selenium.search.locators
{
    public class IdStrategy : Strategy
    {
        private IWebDriver Driver;

        public IdStrategy()
        {
        }

        public IdStrategy(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool DoAction(string selector)
        {
            return Driver.FindElement(By.Id(selector)).Displayed;
        }
    }
}
