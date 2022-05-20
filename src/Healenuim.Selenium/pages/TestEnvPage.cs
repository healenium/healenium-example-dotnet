using System.Linq;
using Healenuim.Selenium.constants;
using Healenuim.Selenium.search;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Healenuim.Selenium.pages
{
    public interface ITestEnvPage
    {
        ITestEnvPage OpenPage();
        ITestEnvPage FindTestElement(LocatorType type, string selector);
        ITestEnvPage ClickSubmitButton();
        ITestEnvPage FindElementsUnderParent(string parentXpath, string childXpath);
        ITestEnvPage ClickFormButton();
        ITestEnvPage SelectCheckboxesUnderParent();
        ITestEnvPage SelectCheckboxes();
    }

    public class TestEnvPage : BasePage, ITestEnvPage
    {
        private By _submitButton = By.Id("Submit");
        private By _formButton = By.Id("Submit_checkbox");

        public TestEnvPage(IWebDriver driver) : base(driver) { }

        public ITestEnvPage OpenPage()
        {
            Driver.Navigate().GoToUrl(PageUrl.TestEnvUrl.ToString());
            return this;
        }

        public ITestEnvPage FindTestElement(LocatorType type, string selector)
        {
            var result = new Context(Driver, type).ExecuteStrategy(selector);
            Assert.IsTrue(result);
            return this;
        }

        public ITestEnvPage ClickSubmitButton()
        {
            Driver.FindElement(_submitButton).Click();
            return this;
        }

        public ITestEnvPage FindElementsUnderParent(string parentXpath, string childXpath)
        {
            var formElements = Driver.FindElement(By.XPath(parentXpath))
                .FindElements(By.XPath("." + childXpath))
                .ToList();
            formElements.ForEach(f => f.Click());
            return this;
        }

        public ITestEnvPage ClickFormButton()
        {
            Driver.FindElement(_formButton).Click();
            return this;
        }

        public ITestEnvPage SelectCheckboxesUnderParent()
        {
            var checkboxes = Driver.FindElement(By.XPath("//*[contains(@class,'test-form')]"))
                .FindElements(By.XPath(".//*[@class='input1']"))
                .ToList();
            checkboxes.ForEach(ch => ch.Click());
            return this;
        }

        public ITestEnvPage SelectCheckboxes()
        {
            var checkboxes = Driver.FindElements(By.XPath("//*[contains(@class,'test-form')]//*[@class='input1']")).ToList();
            checkboxes.ForEach(ch => ch.Click());
            return this;
        }
    }
}
