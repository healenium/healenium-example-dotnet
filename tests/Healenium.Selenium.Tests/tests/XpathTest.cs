using Healenium.Selenium.constants;
using NUnit.Framework;

namespace Healenium.Selenium.Tests.tests
{
    public class XpathTest : BaseTest
    {
        [Test]
        [Description("XPath with special characters")]
        public void testXpathSpecialCharacter()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change:name']")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change:name']");
        }

        [Test]
        [Description("XPath Following")]
        public void testXpathFollowing()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change_className']/following::test_tag")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change_className']/following::test_tag");
        }

        [Test]
        [Description("XPath Contains")]
        public void testXpathContains()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//input[contains(@class, 'test')]")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//input[contains(@class, 'test')]");
        }

        [Test]
        [Description("XPath Not Contains")]
        public void testXpathNotContains()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//input[not(contains(@class, 'input1'))]")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//input[not(contains(@class, 'input1'))]");
        }

        [Test]
        [Description("XPath Following-Sibling")]
        public void testXpathFollowingSibling()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//*[starts-with(@class, 'test')]/following-sibling::*")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//*[starts-with(@class, 'test')]/following-sibling::*");
        }

        [Test]
        [Description("XPath Ancestor::")]
        public void testXPathAncestor()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "(//*[starts-with(@class, 'test')]/ancestor::div[@class='healenium-form validate-form']//input)[1]")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "(//*[starts-with(@class, 'test')]/ancestor::div[@class='healenium-form validate-form']//input)[1]");
        }

        [Test]
        [Description("XPath OR")]
        public void testXpathOR()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change_id' or @id='omg']")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change_id' or @id='omg']");
        }

        [Test]
        [Description("XPath And")]
        public void testXpathAnd()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change_id' and @type='text']")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change_id' and @type='text']");
        }

        [Test]
        [Description("XPath Starts-with")]
        public void testXpathStartsWith()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//*[starts-with(@class, 'test')]")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//*[starts-with(@class, 'test')]");
        }

        [Test]
        [Description("XPath Precending::")]
        public void testXpathPrecending()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change_className']/preceding::*[@id='change_id']")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='change_className']/preceding::*[@id='change_id']");
        }

        [Test]
        [Description("XPath Descendant::")]
        public void testXpathDescendant()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='descendant_change']/descendant::input")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Xpath, "//*[@id='descendant_change']/descendant::input");
        }

        [Test]
        [Description("XPath Hover")]
        public void testXpathHover()
        {

        }
    }
}
