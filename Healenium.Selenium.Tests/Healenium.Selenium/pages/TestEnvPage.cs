using Healenium.Selenium.constants;
using Healenium.Selenium.search;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Healenium.Selenium.pages
{
    public interface ITestEnvPage
    {
        ITestEnvPage OpenPage();
        ITestEnvPage FindTestElement(LocatorType type, string selector);
        ITestEnvPage ClickSubmitButton();
        void ClickWaitButton();
        void ClickWaitElement();
        void DisableHealingScript(string script);
        ITestEnvPage FindElementsUnderParent(string parentXpath, string childXpath);
        ITestEnvPage ClickFormButton();
        ITestEnvPage SelectCheckboxesUnderParent();
        ITestEnvPage SelectCheckboxes();
    }

    public class TestEnvPage : BasePage, ITestEnvPage
    {
        private By _submitButton = By.Id("Submit");
        private By _waitButton = By.Id("Wait_Submit");
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
            // Assert.IsTrue(result);
            return this;
        }

        public ITestEnvPage ClickSubmitButton()
        {
            Driver.FindElement(_submitButton).Click();
            return this;
        }
        
        public void ClickWaitButton()
        {
            Driver.FindElement(_waitButton).Click();
        }
        
        public void ClickWaitElement()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(driver =>
            {
                try
                {
                    var elem = driver.FindElement(By.Id("wait_new_element"));
                    return elem.Displayed ? elem : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
            element.Click();
        }
        
        public void DisableHealingScript(string script)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor) Driver;
            jsExecutor.ExecuteScript(script);
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

