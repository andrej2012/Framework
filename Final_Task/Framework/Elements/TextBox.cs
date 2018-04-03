using NLog;
using OpenQA.Selenium;
namespace Framework.Elements
{
    public class TextBox : BaseElement
    {
        public string Name;
        Logger logger = LogManager.GetCurrentClassLogger();
        public TextBox(By locator, IWebDriver driver, string name)
        {
            Locator = locator;
            Driver = driver;
            Name = name;
        }                     
        public bool IsEnterText() 
           {
               logger.Debug("Enter Text");
               bool test = IsElementAvailability(Locator);
               if (test)
               {
                   logger.Debug("Succsess Enter Text");
                   IWebElement SearchInput1 = Driver.FindElement(Locator);
                   SearchInput1.Clear();
                   SearchInput1.SendKeys(Name);
                   return true;
               }
               else
               {
                   logger.Debug("Failed Enter Text");
                   return false;
               }                                 
           }
        public bool IsEnterTextEnter() 
           {
               logger.Debug("Enter Text");
               bool test = IsElementAvailability(Locator);
               if (test)
               {
                   logger.Debug("Succsess Enter Text");
                   IWebElement SearchInput1 = Driver.FindElement(Locator);
                   SearchInput1.Clear();
                   SearchInput1.SendKeys(Name + OpenQA.Selenium.Keys.Enter);
                   return true;
               }
               else
               {
                   logger.Debug("Failed Enter Text");
                   return false;
               }                                 
           }        
    }
}
