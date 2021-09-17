using OpenQA.Selenium;

namespace Healenuim.Selenium.pages
{
    public class CallbackTestPage : BasePage
    {
        By _addSquareButton = By.XPath("//button[contains(@class, 'add')]");
        By _updateSquareButton = By.XPath("//button[contains(@class, 'update')]");
        By _removeSquareButton = By.XPath("//button[contains(@class, 'remove')]");

        By _testButton = By.XPath("//custom-square[contains(@c, 'red')]");
        By _testButtonCss = By.CssSelector("[c='red']");

        public CallbackTestPage(IWebDriver driver) : base(driver) { }

        public CallbackTestPage Open()
        {
            _driver.Navigate().GoToUrl(_callbackTestPageUrl);
            return this;
        }

        public bool VerifyShadowElement() => GetTestButton().Enabled;

        public bool VerifySquareElement()
        {
            return _driver.FindElement(_testButtonCss).Enabled;
        }

        public CallbackTestPage ClickAddSquareButton()
        {
            _driver.FindElement(_addSquareButton).Click();
            return this;
        }

        public CallbackTestPage ClickUpdateSquareButton()
        {
            _driver.FindElement(_updateSquareButton).Click();
            return this;
        }

        public CallbackTestPage ClickRemoveSquareButton()
        {
            _driver.FindElement(_removeSquareButton).Click();
            return this;
        }

        private IWebElement GetTestButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            IWebElement shadowRoot = _driver.FindElement(_testButton);
            return (IWebElement)js.ExecuteScript("return arguments[0].shadowRoot", shadowRoot);
        }
    }
}
