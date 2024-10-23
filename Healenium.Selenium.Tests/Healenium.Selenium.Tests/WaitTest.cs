using System;

namespace Healenium.Selenium.Tests
{
    public class WaitTest : BaseTest
    {
        [Test]
        [Description("Conditional wait for simple locator")]
        public void TestConditionWait()
        {
            _testEnvPage.OpenPage().ClickWaitButton();
            _testEnvPage.DisableHealingScript("disable_healing_true");
            _testEnvPage.ClickWaitElement();
            _testEnvPage.DisableHealingScript("disable_healing_false");
        }
    }
}

