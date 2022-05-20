using OpenQA.Selenium;

namespace Healenuim.Selenium.search.locators
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
