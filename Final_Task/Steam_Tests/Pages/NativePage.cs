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
    public class NativePage :BasePage
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public string UrlHomePage = "https://fstoppers.com/category/nature";
        public By PageLocator = By.XPath("//a[contains(@class,'username')]");
        public By SearchLocator = By.XPath("//input[contains(@class,'form-text')]");
        public By MembersLocator = By.XPath("//div[contains(@data-index,'3')]");
        public string profile_name = "";
        public NativePage()
        {          
        }
        public bool SearchName()
        {
            logger.Debug("SearchName");
            bool test = PageTest(PageLocator);
            if (test)
            {
                logger.Debug("Succsses SearchName");               
                profile_name = GetText(PageLocator, PageLocator);               
                PageTextBoxEnter(PageLocator, SearchLocator, profile_name);
                PageButtonClick(PageLocator, MembersLocator);                
                return true;
            }
            else
            {
                logger.Debug("Failed SearchName");
                return false;
            }
        }
        public bool SearchNameChecked()
        {
            logger.Debug("SearchNameChecked");           
            bool test = PageButtonNameCheck(PageLocator, PageLocator, profile_name);
            if (test)
            {
                logger.Debug("Succsses SearchNameChecked");
                return true;
            }
            else
            {
                logger.Debug("Failed SearchNameChecked");
                return false;
            }
        }
    }
}
