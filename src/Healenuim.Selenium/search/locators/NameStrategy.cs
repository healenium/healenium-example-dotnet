using OpenQA.Selenium;

namespace Healenuim.Selenium.search.locators
{
    public class NameStrategy : Strategy
    {
        private IWebDriver Driver;

        public NameStrategy()
        {
        }

        public NameStrategy(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool DoAction(string selector)
        {
            return Driver.FindElement(By.Name(selector)).Displayed;
        }
    }
}
