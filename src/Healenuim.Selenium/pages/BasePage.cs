using OpenQA.Selenium;

namespace Healenuim.Selenium.pages
{
    public class BasePage
    {
        protected IWebDriver _driver;
        protected string _mainPageUrl = "https://sha-test-app.herokuapp.com/";
        protected string _callbackTestPageUrl = "https://mdn.github.io/web-components-examples/life-cycle-callbacks/";

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public void ConfirmAlert()
        {
            IAlert alert = _driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
