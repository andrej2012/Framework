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
    public class AccountSettingsPage : BasePage
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public By PageLocator = By.Id("edit-current-pass");
        public string UrlHomePage = "https://fstoppers.com/user/163535/edit";        
        public By OldPasswordLocator = By.Id("edit-current-pass");
        public By NewPasswordLocator1 = By.Id("edit-pass-pass1");
        public By NewPasswordLocator2 = By.Id("edit-pass-pass2");
        public string OldPassword = "Selenium";
        public string NewPassword = "Selenium1";
        public By Name_Account_Test = By.ClassName("profile-link");
        public By LogautButton = By.XPath("//a[contains(@href,'/user/logout')]");
        public AccountSettingsPage()
        {          
        }
        public bool ChangePassword()
        {
            bool test = PageTest(PageLocator);
            if (test)
            {
                logger.Debug("ChangeNamePassword");
                PageTextBoxEnter(PageLocator, OldPasswordLocator, OldPassword);
                PageTextBoxEnter(PageLocator, NewPasswordLocator1, NewPassword);
                PagePasswordAndEnter(PageLocator, NewPasswordLocator2, NewPassword);
                logger.Debug("Succsses ChangeNamePassword");
                return true;
            }
            else
            {
                logger.Debug("Failed ChangeNamePassword");
                return false;
            }
        }
        public bool ReturnPassword()
        {
            bool test = PageTest(PageLocator);
            if (test)
            {
                logger.Debug("ChangeNamePassword");
                PageTextBoxEnter(PageLocator, OldPasswordLocator, NewPassword);
                PageTextBoxEnter(PageLocator, NewPasswordLocator1, OldPassword);
                PagePasswordAndEnter(PageLocator, NewPasswordLocator2, OldPassword);
                logger.Debug("Succsses ChangeNamePassword");
                return true;
            }
            else
            {
                logger.Debug("Failed ChangeNamePassword");
                return false;
            }
        }
        public bool Logaut()
        {
            logger.Debug("Click Edit Profile");
            bool test = PageComboBoxClick(PageLocator, Name_Account_Test, LogautButton);
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
    }
}
