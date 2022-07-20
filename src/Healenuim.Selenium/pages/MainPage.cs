using Healenium.Selenium.constants;
using OpenQA.Selenium;
using System;

namespace Healenium.Selenium.pages
{
    public interface IMainPage
    {
        IMainPage ClickTestButtonWaitor(int seconds);
        IMainPage OpenPage();
        IMainPage GenerateMarkup();
        IMainPage ClickTestButton();
        IMainPage ClickTestGeneratedButton();
        void ConfirmAlert();
    }

    public class MainPage : BasePage, IMainPage
    {
        private By _generateMarkupBtnId = By.Id("markup-generation-button");
        private By _testButton = By.ClassName("default-btn");
        private By _testGeneratedButton = By.Id("random-id");

        public IMainPage ClickTestButtonWaitor(int seconds)
        {
            throw new NotImplementedException();
        }

        public MainPage(IWebDriver driver) : base(driver) { }

        public IMainPage OpenPage()
        {
            Driver.Navigate().GoToUrl(PageUrl.MarkupUrl);
            return this;
        }

        public IMainPage GenerateMarkup()
        {
            Driver.FindElement(_generateMarkupBtnId).Click();
            return this;
        }

        public IMainPage ClickTestButton()
        {
            Driver.FindElement(_testButton).Click();
            return this;
        }

        public IMainPage ClickTestGeneratedButton()
        {
            Driver.FindElement(_testGeneratedButton).Click();
            return this;
        }

        public void ConfirmAlert()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
