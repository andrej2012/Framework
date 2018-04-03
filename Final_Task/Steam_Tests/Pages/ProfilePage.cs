using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Elements;
using NLog;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Framework.BrowserManager;
using Framework.Pages;


namespace Steam_Tests.Pages
{
    public class ProfilePage : BasePage
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public By PageLocator = By.XPath("//div[contains(@itemprop,'name')]");
        public string UrlHomePage = "https://fstoppers.com/profile/158549";
        public string NewNameProfile = "First_Name1 Last_Name1";
        public string OldNameProfile = "First_Name Last_Name";
        public ProfilePage()
        {
        }
        public bool IsChangeNameSuccess()
        {            
            logger.Debug("Change Name Success");
            bool test = PageButtonNameCheck(PageLocator, PageLocator, NewNameProfile);
            if (test)
            {
                logger.Debug("Succsses Change Name Success");
                return true;
            }
            else
            {
                logger.Debug("Failed Change Name Success");
                return false;
            }
        }    
    }
}
