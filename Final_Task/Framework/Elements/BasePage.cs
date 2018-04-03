using OpenQA.Selenium;
using Framework.Elements;
using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using NLog;
using Framework.BrowserManager;
using OpenQA.Selenium.Interactions;



namespace Framework.Pages
{
    public abstract class BasePage
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public static IWebDriver Driver;
        
        public BasePage()
        {
            if (Driver == null)
            {
                Singleton Browser_name = new Singleton();
                Driver = Browser_name.Browser;
                Driver.Manage().Window.Maximize();                
            } 
        }
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
        public void WaitShowElement(By iClassName)
        {
            logger.Debug("Wait Show Element");
            WebDriverWait iWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            iWait.Until(ExpectedConditions.ElementExists(iClassName));
        }
        public bool PageGo(string UrlHomePage, By PageLocator)
        {
            logger.Debug("Go To Page");
            Driver.Navigate().GoToUrl(UrlHomePage);
            bool test = PageTest(PageLocator);
            if (test)
            {
                logger.Debug("Succsses Go To Page");
                return true;
            }
            else
            {
                logger.Debug("Failed Go To Page");
                return false;
            }
        }    
        public bool PageTest(By locator)
        {
            logger.Debug("Page Test");
            bool test = IsElementAvailability(locator);
            if (test) 
            {
                logger.Debug("Succsses Page Test");
                return true;
            }
            else
            {
                logger.Debug("SuccssesPage Test");
                return false;
            } 
        }
        public bool Actions(By locator)
        {
            logger.Debug("Page Test");
            bool test = IsElementAvailability(locator);
            if (test)
            {                
                logger.Debug("Click Actions");
                Actions actions = new Actions(Driver);
                actions.MoveToElement(Driver.FindElement(locator)).Build().Perform();
                Thread.Sleep(1000); //ToDo
                return true;
            }
            else
            {
                logger.Debug("SuccssesPage Test");
                return false;
            }
        }
        public void ClickCheckBox(int n, string LocatorClassName)
        {
            string Locator = "document.getElementsByClassName('";
            string Locator_Middle = "')[";
            string Locator_End = "].click();";            
            string Num = Convert.ToString(n);
            Locator = Locator + LocatorClassName + Locator_Middle + Num + Locator_End;
            IJavaScriptExecutor jse = Driver as IJavaScriptExecutor;
            jse.ExecuteScript(Locator);                    
        }
        public void ClickButtonJS(string LocatorClassName)
        {
            string Locator = "document.getElementsByClassName('";
            string Locator_End = "')[0].click();";          
            Locator = Locator + LocatorClassName +Locator_End;
            IJavaScriptExecutor jse = Driver as IJavaScriptExecutor;
            jse.ExecuteScript(Locator);
        }
        public void GoToPageJS(By Locator)
        {
            IWebElement Search = Driver.FindElement(Locator);
            IJavaScriptExecutor exec = (IJavaScriptExecutor)Driver;
            exec.ExecuteScript("arguments[0].click();", Search);
        }
        public bool PageButtonClick(By PageLocator, By ButtonLocator)
        {
            logger.Debug("Click Button");
            bool test = PageTest(PageLocator);
            if (test)
            {
                Button ProfilePage = new Button(ButtonLocator, Driver);
                ProfilePage.IsClickButton();
                logger.Debug("Success Click Button");
                return true;
            }
            else
            {
                logger.Debug("Failed Click Button");
                return false;
            }
        }
        public bool PageComboBoxClick(By PageLocator, By ButtonLocator1, By ButtonLocator2)
        {
            logger.Debug("Click ComboBox");
            bool test = PageTest(PageLocator);
            if (test)
            {
                ComboBox ProfilePage = new ComboBox(Driver, ButtonLocator1, ButtonLocator2);
                ProfilePage.IsClickComboBox();
                Thread.Sleep(5000);  //ToDo
                logger.Debug("Success ComboBox");                
                return true;
            }
            else
            {
                logger.Debug("Failed ComboBox");
                return false;
            }
        }
        public bool PageTextBoxEnter(By PageLocator, By ButtonLocator, string Name)
        {
            logger.Debug("Enter Text");
            bool test = PageTest(PageLocator);
            if (test)
            {
                TextBox ProfilePage = new TextBox(ButtonLocator, Driver, Name);
                ProfilePage.IsEnterText();
                logger.Debug("Success Enter Text");
                return true;
            }
            else
            {
                logger.Debug("Failed Enter Text");
                return false;
            }
        }
        public string GetText(By PageLocator, By ButtonLocator)
        {
            logger.Debug("GetText");
            string text = "";
            bool test = PageTest(PageLocator);
            if (test)
            {
                IWebElement SearchInput3 = Driver.FindElement(ButtonLocator);
                text = SearchInput3.Text; 
                logger.Debug("Success Enter Text");
                return text;
            }
            else
            {
                logger.Debug("Failed Enter Text");
                return null;
            }
        }
        public bool PageTextBoxEnter_Enter(By PageLocator, By ButtonLocator, string Name)
        {
            logger.Debug("Enter Text");
            bool test = PageTest(PageLocator);
            if (test)
            {
                TextBox ProfilePage = new TextBox(ButtonLocator, Driver, Name);
                ProfilePage.IsEnterTextEnter();
                logger.Debug("Success Enter Text");
                return true;
            }
            else
            {
                logger.Debug("Failed Enter Text");
                return false;
            }
        }
        public bool PagePasswordAndEnter(By PageLocator, By ButtonLocator, string Password)
        {
            logger.Debug("Enter Password");
            bool test = PageTest(PageLocator);
            if (test)
            {
                IWebElement SearchInput2 = Driver.FindElement(ButtonLocator);
                SearchInput2.SendKeys(Password + OpenQA.Selenium.Keys.Enter);
                logger.Debug("Success Enter Password");
                return true;
            }
            else
            {
                logger.Debug("Failed Enter Password");
                return false;
            }
        }
        public bool PageButtonNameCheck(By PageLocator, By ButtonLocator, string Name)
        {
            logger.Debug("Button Name Check");
            IWebElement NameAccountTest = Driver.FindElement(ButtonLocator);
            string s = NameAccountTest.Text;
            bool test = PageTest(PageLocator);
            if ((s.Contains(Name))&&test)
            {
                logger.Debug("Success Button Name Check");
                return true;
            }
            else
            {
                logger.Debug("Failed Button Name Check");
                return false;
            }
        }
    }
}
