using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Healenuim.Selenium.pages
{
    public class MainPageWithFindBy : BasePage
    {
        [FindsBy(How = How.Id, Using = @"markup-generation-button")]
        private IWebElement _generateMarkupBtnId { get; set; }

        [FindsBy(How = How.XPath, Using = @"//button[contains(@class,'default-btn')]")]
        private IWebElement _testButton { get; set; }

        [FindsBy(How = How.Id, Using = @"for-invisible-test")]
        private IWebElement _buttonForInvisible { get; set; }

        [FindsBy(How = How.Id, Using = @"field-parent")]
        private IWebElement _fieldParent { get; set; }

        public MainPageWithFindBy(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public MainPageWithFindBy Open()
        {
            _driver.Navigate().GoToUrl(_mainPageUrl);
            return this;
        }

        public MainPageWithFindBy GenerateMarkup()
        {
            _generateMarkupBtnId.Click();
            return this;
        }

        public MainPageWithFindBy ClickTestButton()
        {
            _testButton.Click();
            return this;
        }

        public MainPageWithFindBy ClickButtonForInvisible()
        {
            _buttonForInvisible.Click();
            return this;
        }

        public bool CheckThatButtonInvisible()
        {
            try
            {
                new WebDriverWait(_driver, new TimeSpan(0, 0, 5))
                        .Until(ExpectedConditions.ElementIsVisible((By)_buttonForInvisible));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public MainPageWithFindBy HoverOnTestButton()
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(_testButton).Perform();
            return this;
        }

        public string TakeValueFromSecondButton()
        {
            return _fieldParent
                    .FindElement(By.XPath(".//input"))
                    .GetAttribute("Value");
        }

        public string GetAttributeFromTestButton(string attribute)
        {
            return _testButton.GetAttribute(attribute);
        }

        public bool CheckLocatorTestButtonDontHealing()
        {
            try
            {
                _testButton.Click();
                return false;
            }
            catch (NoSuchElementException)
            {
                return true;
            }
        }

    }
}
