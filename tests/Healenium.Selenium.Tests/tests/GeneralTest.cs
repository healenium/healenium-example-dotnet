using NUnit.Framework;

namespace Healenium.Selenium.Tests.tests
{
    public class GeneralTest : BaseTest
    {

        [Test]
        [Description("Verify healing for FindElements action")]
        public void TestSelectCheckboxes()
        {
            _testEnvPage.OpenPage()
                .SelectCheckboxes()
                .ClickFormButton()
                .SelectCheckboxes();
        }
    }
}
