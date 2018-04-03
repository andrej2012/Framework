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
    public class CategoriesPage : BasePage
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public string UrlHomePage = "https://fstoppers.com/categories";
        public By PageLocator = By.XPath("//a[contains(@href,'https://fstoppers.com/category/nature')]");
        public CategoriesPage()
        {          
        }
        public bool NativeButton()
        {
            logger.Debug("Click NativeButton");
            bool test = PageButtonClick(PageLocator, PageLocator);
            if (test)
            {
                logger.Debug("Succsses Click NativeButton");
                return true;
            }
            else
            {
                logger.Debug("Failed Click NativeButton");
                return false;
            }
        }
    }   
}
