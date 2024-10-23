using System;
using Healenium.Selenium.constants;
using OpenQA.Selenium;

namespace Healenium.Selenium.pages
{
    public interface ICallbackPage
    {
        ICallbackPage OpenPage();
        bool VerifySquareElement();
        ICallbackPage ClickAddSquareButton();
        ICallbackPage ClickUpdateSquareButton();
        ICallbackPage ClickRemoveSquareButton();
    }

    public class CallbackTestPage : BasePage, ICallbackPage
    {
        private By _addSquareButton = By.XPath("//button[contains(@class, 'add')]");
        private By _updateSquareButton = By.XPath("//button[contains(@class, 'update')]");
        private By _removeSquareButton = By.XPath("//button[contains(@class, 'remove')]");

        private By _testButtonCss = By.CssSelector("[color='red']");

        public CallbackTestPage(IWebDriver driver) : base(driver) { }

        public ICallbackPage OpenPage()
        {
            Driver.Navigate().GoToUrl(PageUrl.CallbackUrl.ToString());
            return this;
        }

        public bool VerifySquareElement()
        {
            return Driver.FindElement(_testButtonCss).Enabled;
        }

        public ICallbackPage ClickAddSquareButton()
        {
            Driver.FindElement(_addSquareButton).Click();
            return this;
        }

        public ICallbackPage ClickUpdateSquareButton()
        {
            Driver.FindElement(_updateSquareButton).Click();
            return this;
        }

        public ICallbackPage ClickRemoveSquareButton()
        {
            Driver.FindElement(_removeSquareButton).Click();
            return this;
        }
    }
}

