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
using System.Text.RegularExpressions;


namespace Steam_Tests.Pages
{
    public class HomePage :BasePage
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public By PageLocator = By.XPath("//ul[contains(@class,'quicktabs-tabs quicktabs-style-nostyle')]");
        public string UrlHomePage = "http://fstoppers.com/";
        public By HomePageLoginButton = By.XPath("//a[contains(@href,'https://fstoppers.com/user?destination=node/163438')]");
        public By Login_name = By.Id("edit-name");
        public By Password_name = By.Id("edit-pass");
        public string Login = "www.2010-k.andrej@mail.ru";
        public string Password = "Selenium";
        public string NewPassword = "Selenium1";
        public By EditRememberMe = By.Id("edit-remember-me");
        public By Name_Account_Test = By.ClassName("profile-link");
        public By EditProfileButton = By.XPath("//a[contains(@href,'/user/163535/profile')]");
        public By GroupButton = By.XPath("//a[contains(@href,'/groups')]");
        public By CpamButton = By.Id("no-subscribe-link");
        public By AllCategories = By.XPath("//a[contains(@href,'/categories')]");
        public By ArticlesLocator = By.XPath("//a[contains(@data-section,'articles')]");
        public By GroupLocator = By.XPath("//a[contains(@href,'/groups')]");
        public string NameNews = "";
        public string OriginalsLocator = "quicktabs-tab quicktabs-tab-view quicktabs-tab-view-homepage-articles2-block-originals active ajax-processed jquery-once-3-processed";
        public string JoinToGroupLocator = "button btn green";
        public By NewsLocator = By.XPath("//div[@id='quicktabs-tabpage-homepage_articles-1']//article[@id='node-198664']//h2//a");
        public By CheckNameNewsLocator = By.XPath("//div[contains(@class,'views-row views-row-1 views-row-odd views-row-first')]");
        public By IsNewsNameCheckedLocator = By.XPath("//div[contains(@id,'main')]");
        public HomePage()
        {          
        }
        public bool LoginButton()
        {
            logger.Debug("Click LoginButton");
            bool test = PageButtonClick(PageLocator, HomePageLoginButton);
            Thread.Sleep(3000);  //ToDo
            if (test)
            {
                logger.Debug("Succsses Click LoginButton");
                return true;
            }
            else
            {
                logger.Debug("Failed Click LoginButton");
                return false;
            }
        }
        public bool LoginClick()
        {
            bool test = PageTest(PageLocator);
            if (test)
            {
                logger.Debug("Login");
                PageButtonClick(PageLocator, EditRememberMe);
                PageTextBoxEnter(PageLocator, Login_name, Login);
                PagePasswordAndEnter(PageLocator, Password_name, Password);
                Thread.Sleep(5000);  //ToDo
                logger.Debug("Succsses Login");
                return true;
            }
            else
            {
                logger.Debug("Failed Login");
                return false;
            }
        }
        public bool NewLogin()
        {
            bool test = PageTest(PageLocator);
            if (test)
            {
                logger.Debug("Login");
                PageButtonClick(PageLocator, EditRememberMe);
                PageTextBoxEnter(PageLocator, Login_name, Login);
                PagePasswordAndEnter(PageLocator, Password_name, NewPassword);
                Thread.Sleep(5000);   //ToDo
                logger.Debug("Succsses Login");
                return true;
            }
            else
            {
                logger.Debug("Failed Login");
                return false;
            }
        }
        public bool EditProfile()
        {
            logger.Debug("Click Edit Profile");
            bool test = PageComboBoxClick(PageLocator, Name_Account_Test, EditProfileButton);
            if (test)
            {
                logger.Debug("Succsses Edit Profile");
                return true;
            }
            else
            {
                logger.Debug("Failed Edit Profile");
                return false;
            }
        }
        public void ClickGroupAndJoin()
        {
            logger.Debug("Click ClickGroupAndJoin");
            Actions(GroupLocator);
            ClickButtonJS(JoinToGroupLocator);
            Thread.Sleep(1000);  //ToDo
        }
        public void ClickArticlesAndClickAll()
        {
            logger.Debug("Click ClickArticlesAndClickAll");
            Actions(ArticlesLocator);            
            PageButtonClick(PageLocator, AllCategories);
        }
        public bool GroupButtonClick()
        {
            logger.Debug("Click GroupButton");
            bool test = PageButtonClick(PageLocator, GroupButton);
            Thread.Sleep(1000);  //ToDo
            if (test)
            {
                logger.Debug("Succsses Click GroupButton");
                return true;
            }
            else
            {
                logger.Debug("Failed Click GroupButton");
                return false;
            }
        }        
        public bool SpamButton()
        {
            logger.Debug("Click SpamButton");
            bool test = PageButtonClick(PageLocator, CpamButton);
            Thread.Sleep(1000);  //ToDo
            if (test)
            {
                logger.Debug("Succsses Click SpamButton");
                return true;
            }
            else
            {
                logger.Debug("Failed Click SpamButton");
                return false;
            }
        }
        public void CheckOriginals()
        {
            logger.Debug("Click CheckOriginals");
            ClickButtonJS(OriginalsLocator);
            Thread.Sleep(3000);  //ToDo
        }
        public void CheckNameNews()
        {
            logger.Debug("Click CheckNameNews");
            List<IWebElement> News = Driver.FindElements(CheckNameNewsLocator).ToList();
            Regex myReg = new Regex("[by]");
            string[] names = myReg.Split(News[3].Text);
            Regex myReg1 = new Regex("[\n]");
            string[] names1 = myReg1.Split(names[0]);
            NameNews = names1[0];
        }
        public void GoToNews()
        {
            logger.Debug("Click CheckNameNews");
            GoToPageJS(NewsLocator); 
        }
        public bool IsNewsNameChecked()
        {
            logger.Debug("SearchNameChecked");
            List<IWebElement> News1 = Driver.FindElements(IsNewsNameCheckedLocator).ToList();
            Regex myReg2 = new Regex("[by]");
            string[] names2 = myReg2.Split(News1[0].Text);
            Regex myReg3 = new Regex("[\n]");
            string[] names3 = myReg3.Split(names2[0]);
            if (NameNews.Contains(names3[1]))
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
