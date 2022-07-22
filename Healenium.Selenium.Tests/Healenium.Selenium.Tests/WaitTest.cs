using System;
namespace Healenium.Selenium.Tests
{
    public class WaitTest : BaseTest
    {
        [Test]
        [Description("Conditional wait for simple locator")]
        public void TestConditionWait()
        {
            _mainPage.OpenPage()
                    .ClickTestButton()
                    .ConfirmAlert();

            _mainPage.GenerateMarkup()
                    .ClickTestButton() //should be healed
                    .ConfirmAlert();

            _mainPage.GenerateMarkup()
                    .ClickTestButtonWaitor(5) //should be healed
                    .ConfirmAlert();
        }
    }
}

