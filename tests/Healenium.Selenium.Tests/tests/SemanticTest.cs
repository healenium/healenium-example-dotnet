using Healenium.Selenium.constants;
using NUnit.Framework;

namespace Healenium.Selenium.Tests.tests
{
    public class SemanticTest : BaseTest
    {

        [Test]
        [Description("Button click with find element by id")]
        public void TestButtonClickWithId()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Id, "change_id")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Id, "change_id");
        }

        [Test]
        [Description("Find element by classname")]
        public void TestFindElementByClassName()
        {
            _mainPage.OpenPage()
                    .ClickTestButton();
            _mainPage.ConfirmAlert();

            _mainPage
                    .GenerateMarkup()
                    .ClickTestButton(); //should be healed
            _mainPage.ConfirmAlert();

        }


        [Test]
        [Description("Find element by linktext")]
        public void TestFindElementByLinkText()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.LinkText, "Change: LinkText, PartialLinkText")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.LinkText, "Change: LinkText, PartialLinkText");
        }

        [Test]
        [Description("Find element by name")]
        public void TestFindElementByName()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Name, "change_name")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Name, "change_name");
        }

        [Test]
        [Description("Find element by partialLinkText")]
        public void TestFindElementByPartialLinkText()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.PartialLinkText, "PartialLinkText")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.PartialLinkText, "PartialLinkText");
        }

        [Test]
        [Description("Find element by tagName")]
        public void TestFindElementByTagName()
        {
            _testEnvPage.OpenPage()
                    .FindTestElement(LocatorType.Tag, "test_tag")
                    .ClickSubmitButton()
                    .FindTestElement(LocatorType.Tag, "test_tag");
        }
    }
}
