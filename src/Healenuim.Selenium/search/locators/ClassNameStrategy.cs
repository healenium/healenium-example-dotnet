using OpenQA.Selenium;

namespace Healenium.Selenium.search.locators
{
    public class ClassNameStrategy : Strategy
    {
        private IWebDriver Driver;

        public ClassNameStrategy()
        {
        }

        public ClassNameStrategy(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool DoAction(string selector)
        {
            return Driver.FindElement(By.ClassName(selector)).Displayed;
        }
    }
}
