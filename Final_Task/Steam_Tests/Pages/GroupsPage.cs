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
    public class GroupsPage : BasePage
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public By PageLocator = By.XPath("//a[contains(@class,'quicktabs-tab quicktabs-tab-view quicktabs-tab-view-og-all-user-group-content-page-2 active ajax-processed quicktabs-loaded jquery-once-3-processed')]");
        public string UrlHomePage = "https://fstoppers.com/groups";
        public string CheckedLocator = "button btn use-ajax group-leave-80197-158549 grey ajax-processed";
        public GroupsPage()
        {          
        }
        public void ClickGroupSuccess()
        {
            logger.Debug("Change Name Success");
            ClickButtonJS(CheckedLocator);            
        }    
    }    
}
