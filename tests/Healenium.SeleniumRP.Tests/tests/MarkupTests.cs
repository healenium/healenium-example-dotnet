using Healenuim.Selenium.pages;
using NUnit.Framework;

namespace Healenium.SeleniumRP.Tests.tests
{
    public class MarkupTests : BaseTest
    {
        [Test]
        [Description("Button click with FindBy annotation")]
        public void TestButtonClickWithFindByAnnotationPage()
        {
            MainPageWithFindBy mainPage = new MainPageWithFindBy(_driver);

            var invisible = mainPage.Open()
                .ClickButtonForInvisible()
                .CheckThatButtonInvisible();

            mainPage.Open()
                .ClickTestButton();
            mainPage.ConfirmAlert();

            mainPage.GenerateMarkup()
                .ClickTestButton(); //should be healed
            mainPage.ConfirmAlert();  //confirm Alert again
        }

        [Test]
        [Description("Button click with findElement annotation")]
        public void TestButtonClickWithFindElementPage()
        {
            MainPage mainPage = new MainPage(_driver);
            mainPage.Open()
                    .ClickTestButton();
            mainPage.ConfirmAlert();

            mainPage
                .GenerateMarkup()
                .ClickTestButton(); //should be healed
            mainPage.ConfirmAlert();
        }

        [Test]
        [Description("Button click with disable healing")]
        public void TestButtonClickWithDisableHealing()
        {
            MainPageWithFindBy mainPage = new MainPageWithFindBy(_driver);

            mainPage.Open()
                    .ClickTestButton()
                    .ConfirmAlert();
            bool result = mainPage
                    .GenerateMarkup() //regenerate Markup
                    .CheckLocatorTestButtonDontHealing(); //find test button again
            Assert.IsTrue(result, "The locator was not healed");
        }

        [Test]
        [Description("Select checkboxes with findElements annotation")]
        public void TestSelectCheckboxes()
        {
            MainPage mainPage = new MainPage(_driver);
            mainPage.Open()
                .GenerateMarkup();

            while (!mainPage.DisplayedText())
                mainPage.GenerateMarkup();

            for (int i = 0; i <= 10; i++)
            {
                mainPage.SelectFirstCheckbox();
            }
            bool result = mainPage.VerifyFirstCheckbox();  //should be healed
            Assert.IsTrue(result, "Locator for checkbox with findElements has been healed");
        }

        [Test]
        [Description("Button click with find element by id")]
        public void TestButtonClickWithId()
        {
            MainPage mainPage = new MainPage(_driver);
            mainPage.Open()
                    .ClickTestButton();
            mainPage.ConfirmAlert();
            mainPage.GenerateMarkup();

            while (!mainPage.TestButtonEnable())
                mainPage.GenerateMarkup();

            for (int i = 0; i < 3; i++)
            {
                mainPage.ClickTestGeneratedButton();//should be healed
                mainPage.GenerateMarkup();
            }
        }
    }
}
