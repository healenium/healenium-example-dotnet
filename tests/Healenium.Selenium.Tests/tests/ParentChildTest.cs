using Healenuim.Selenium.constants;
using NUnit.Framework;

namespace Healenium.Selenium.Tests.tests
{
    public class ParentChildTest : BaseTest
    {
        [Test]
        [Description("Select first checkbox and verify using parent:: function in Xpath")]
        public void TestParentXpath()
        {
            _testEnvPage.OpenPage()
                .FindTestElement(LocatorType.Xpath, "(//*[@class='input1']//parent::*[contains(@class, 'input1')])[8]")
                .ClickSubmitButton()
                .FindTestElement(LocatorType.Xpath, "(//*[@class='input1']//parent::*[contains(@class, 'input1')])[8]");
        }

        [Test]
        [Description("Select and verify several inputs via parent.findElement")]
        public void TestUnderParentFindElements()
        {
            _testEnvPage.OpenPage()
                .SelectCheckboxesUnderParent()
                .ClickFormButton()
                .SelectCheckboxesUnderParent();
        }

        [Test]
        [Description("Select and verify several inputs CSS FirstChild")]
        public void TestCSSFirstChild()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Css, "test_tag:first-child")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Css, "test_tag:first-child");
        }

        [Test]
        [Description("Select and verify several inputs CSS LastChild")]
        public void TestCSSLastChild()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Css, "child_tag:last-child")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Css, "child_tag:last-child");
        }

        [Test]
        [Description("Select first checkbox and verify using parent.findElements in Xpath. " +
            "The difference between first - not use @DisabledHealing")]
        public void TestXPathUnderParentFindElements()
        {
            string parentXpath = "//*[contains(@class,'test-form')]";
            string childXpath = "//*[@class='input1']";
            _testEnvPage.OpenPage()
                    .FindElementsUnderParent(parentXpath, childXpath)
                    .ClickFormButton()
                    .FindElementsUnderParent(parentXpath, childXpath);
        }
        // selenium 4 (above, below, toLeftOf, toRightOf, near)
    }
}

