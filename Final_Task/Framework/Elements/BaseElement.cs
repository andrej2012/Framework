using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace Framework.Elements
{
    public abstract class BaseElement
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        protected By Locator { get; set; }
        protected IWebDriver Driver;
        public bool IsElementAvailability(By locator)
        {
            try
            {
                logger.Debug("Element availability test");
                Assert.IsTrue(!Driver.FindElement(locator).Size.IsEmpty, "Element availability test");
                return true;
            }
            catch (NoSuchElementException)
            {
                logger.Debug("Failed Element availability test");
                return false;
            }
        }
               
    }
}
