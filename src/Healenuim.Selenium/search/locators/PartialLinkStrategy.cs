using OpenQA.Selenium;

namespace Healenium.Selenium.search.locators
{
    public class PartialLinkStrategy : Strategy
    {
        private IWebDriver Driver;

        public PartialLinkStrategy()
        {
        }

        public PartialLinkStrategy(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool DoAction(string selector)
        {
            return Driver.FindElement(By.PartialLinkText(selector)).Displayed;
        }
    }
}
