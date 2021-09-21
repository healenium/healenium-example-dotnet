using Healenuim.Selenium.pages;
using NUnit.Framework;

namespace Healenium.SeleniumRP.Tests.tests
{
    public class CallbackTest : BaseTest
    {
        [Test]
        [Ignore(reason: "Firefox driver open issue with shadow root")]
        [Description("Update locator for element from shadow root")]
        public void TestElementFromShadowRoot()
        {
            CallbackTestPage callbackTestPage = new CallbackTestPage(_driver);
            bool result = callbackTestPage
                    .Open()
                    .ClickAddSquareButton()
                    .VerifyShadowElement();
            Assert.IsTrue(result, "Element in shadowRoot enabled");

            // opened issue with shadow root
            //for mozilla OpenQA.Selenium.WebDriverException : Cyclic object value
            result = callbackTestPage
                    .ClickUpdateSquareButton()
                    .VerifyShadowElement(); //should be healed
            Assert.IsTrue(result, "Element in shadowRoot was healed");

        }

        [Test]
        [Description("Update locator for element with css selector")]
        public void TestCssLocators()
        {
            CallbackTestPage callbackTestPage = new CallbackTestPage(_driver);
            bool result = true;
            callbackTestPage
                .Open()
                .ClickAddSquareButton()
                .VerifySquareElement();
            Assert.IsTrue(result, "Element with css enabled");

            result = callbackTestPage
                    .ClickUpdateSquareButton()
                    .VerifySquareElement(); //should be healed
            Assert.IsTrue(result, "Element with css was healed");

        }
    }
}
