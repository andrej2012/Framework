using NLog;
using OpenQA.Selenium;

namespace Framework.Elements
{
    public class ComboBox : BaseElement
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        protected By Locator2 { get; set; }
        public ComboBox(IWebDriver driver, By locator, By locator2)
        {
            Locator = locator;
            Locator2 = locator2;
            Driver = driver;
        }
        public bool IsClickComboBox()
        {
            logger.Debug("Click ComboBox");
            bool test = IsElementAvailability(Locator);            
            if (test)
            {
                Driver.FindElement(Locator).Click();
                bool test1 = IsElementAvailability(Locator2);
                if (test1)
                {
                    logger.Debug("Sucsses Click ComboBox");
                    Driver.FindElement(Locator2).Click();
                    return true;
                }
                else
                {
                    logger.Debug("Failed Click ComboBox");
                    return false;
                }
            }
            else
            {
                logger.Debug("Failed Click ComboBox");
                return false;
            }      
        }
    }
}
