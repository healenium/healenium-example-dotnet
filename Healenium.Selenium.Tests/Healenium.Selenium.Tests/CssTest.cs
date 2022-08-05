using System;
using Healenium.Selenium.constants;

namespace Healenium.Selenium.Tests
{
    public class CssTest : BaseTest
    {

        [Test]
        [Description("Update locator for element with css attribute")]
        public void TestCssAttribute()
        {
            bool result = _callbackPage
                    .OpenPage()
                    .ClickAddSquareButton()
                    .VerifySquareElement();
            Assert.IsTrue(result, "Element with css enabled");

            for (int i = 0; i <= 2; i++)
            {
                result = _callbackPage
                        .ClickUpdateSquareButton()
                        .VerifySquareElement(); //should be healed
                Assert.IsTrue(result, "Element with css was healed");
            }
        }

        [Test]
        [Description("Update locator for element with css id")]
        public void TestCssId()
        {
            _testEnvPage.OpenPage()
                     .FindTestElement(LocatorType.Css, "#change_id")
                     .ClickSubmitButton()
                     .FindTestElement(LocatorType.Css, "#change_id");
        }

        [Test]
        [Description("Update locator for element with css id with special character")]
        public void TestCssIdSpecialCharacter()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Css, "input#change\\:name")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Css, "input#change\\:name");
        }

        [Test]
        [Description("Update locator for element with css Element")]
        public void TestCssElement()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Css, "test_tag")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Css, "test_tag");
        }

        [Test]
        [Description("Update locator for element with css Disabled")]
        public void TestCssDisabled()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Css, "input:disabled")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Css, "input:disabled");
        }

        [Test]
        [Description("Update locator for element with css Enabled")]
        public void TestCssEnabled()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Css, "textarea:enabled")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Css, "textarea:enabled");
        }

        [Test]
        [Description("Update locator for element with css Checked")]
        public void TestCssChecked()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Css, "input:checked")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Css, "input:checked");
        }

        [Test]
        [Description("Update locator for element with css Hover")]
        public void TestCssHover()
        {

        }

        [Test]
        [Description("Update locator for element with Css ClassName")]
        public void TestCssClassName()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Css, ".test_class")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Css, ".test_class");
        }
    }
}

