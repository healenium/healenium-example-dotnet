using OpenQA.Selenium;
using System.Linq;

namespace Healenuim.Selenium.pages
{
    public class MainPage : BasePage
    {
        By _generateMarkupBtnId = By.Id("markup-generation-button");
        By _testButton = By.ClassName("default-btn");
        By _testGeneratedButton = By.Id("random-id");

        By _checkboxAccount = By.XPath("//*[@class='checkbox checkbox_size_m checkbox_theme_alfa-on-white']");
        By _textFirstSelect = By.XPath("(//*[text()='Select Account'])[1]");

        By _firstCheckboxChecked = By.XPath("//*[text()='Current account']//parent::label[contains(@class,'checked')]");


        public MainPage(IWebDriver driver) : base(driver) { }

        public MainPage Open()
        {
            _driver.Navigate().GoToUrl(_mainPageUrl);
            return this;
        }

        public MainPage GenerateMarkup()
        {
            _driver.FindElement(_generateMarkupBtnId).Click();
            return this;
        }

        public MainPage ClickTestButton()
        {
            _driver.FindElement(_testButton).Click();
            return this;
        }

        public MainPage ClickTestGeneratedButton()
        {
            _driver.FindElement(_testGeneratedButton).Click();
            return this;
        }

        public bool TestButtonEnable()
        {
            try
            {
                return _driver.FindElement(_testGeneratedButton).Enabled;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public bool DisplayedText()
        {
            try
            {
                return _driver.FindElement(_textFirstSelect).Enabled;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }

        public void SelectFirstCheckbox() => _driver.FindElement(_checkboxAccount).Click();

        public bool VerifyFirstCheckbox()
        {
            return _driver.FindElement(_checkboxAccount).Enabled;
        }

        public void SelectAllCheckboxes()
        {
            var checkboxes = _driver.FindElements(_checkboxAccount).ToList();
            checkboxes.ForEach(c => c.Click());
        }

        public bool VerifyFirstAccountCheckbox()
        {
            return _driver.FindElement(_firstCheckboxChecked).Enabled;
        }

        public void SelectFirstAccountCheckbox()
        {
            _driver.FindElement(_firstCheckboxChecked).Click();
        }

    }
}
