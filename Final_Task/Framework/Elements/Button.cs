using NLog;
using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Button : BaseElement
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public Button(By locator, IWebDriver driver)
        {
            Locator = locator;
            Driver = driver;
        }                     
        public bool IsClickButton() 
           {
               logger.Debug("Click Button");
               bool test = IsElementAvailability(Locator);
               if (test)
               {
                   logger.Debug("Success Click Button");
                   Driver.FindElement(Locator).Click(); 
                   return true;
               }
               else
               {
                   logger.Debug("Failed Click Button");
                   return false;
               }                                 
           }
    }
}
