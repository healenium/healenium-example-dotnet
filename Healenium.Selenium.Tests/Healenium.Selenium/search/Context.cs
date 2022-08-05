using System;
using Healenium.Selenium.constants;
using Healenium.Selenium.search.locators;
using OpenQA.Selenium;

namespace Healenium.Selenium.search
{
    public class Context
    {
        private Strategy _strategy;

        public Context(IWebDriver driver, LocatorType type)
        {
            switch (type)
            {
                case LocatorType.Xpath:
                    _strategy = new XPathStrategy(driver);
                    break;
                case LocatorType.Css:
                    _strategy = new CssStrategy(driver);
                    break;
                case LocatorType.Id:
                    _strategy = new IdStrategy(driver);
                    break;
                case LocatorType.ClassName:
                    _strategy = new ClassNameStrategy(driver);
                    break;
                case LocatorType.LinkText:
                    _strategy = new LinkTextStrategy(driver);
                    break;
                case LocatorType.PartialLinkText:
                    _strategy = new PartialLinkStrategy(driver);
                    break;
                case LocatorType.Tag:
                    _strategy = new TagStrategy(driver);
                    break;
                case LocatorType.Name:
                    _strategy = new NameStrategy(driver);
                    break;
            }
        }

        public bool ExecuteStrategy(String selector)
        {
            return _strategy.DoAction(selector);
        }
    }
}

