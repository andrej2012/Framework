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
    public class EditProfilePage : BasePage
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public By PageLocator = By.Id("edit-profile-profile-field-first-name-und-0-value");
        public string UrlHomePage = "https://fstoppers.com/user/158549/profile";
        public By EditFirstName = By.Id("edit-profile-profile-field-first-name-und-0-value");
        public By EditLastName = By.Id("edit-profile-profile-field-last-name-und-0-value");
        public string NewFirstNameProfile = "First_Name1";
        public string OldFirstNameProfile = "First_Name";
        public string NewLastNameProfile = "Last_Name1";
        public string OldLastNameProfile = "Last_Name";
        public By AccountSettingsLocator = By.ClassName("menu-account-settings");
        public EditProfilePage()
        {          
        }
        public bool ChangeName()
        {
            bool test = PageTest(PageLocator);
            if (test)
            {
                logger.Debug("ChangeName");
                PageTextBoxEnter(PageLocator, EditFirstName, NewFirstNameProfile);
                PageTextBoxEnter_Enter(PageLocator, EditLastName, NewLastNameProfile);
                logger.Debug("Succsses ChangeName");
                return true;
            }
            else
            {
                logger.Debug("Failed ChangeNameSuccess");
                return false;
            }
        }
        public bool ReturnName()
        {
            bool test = PageTest(PageLocator);
            if (test)
            {
                logger.Debug("ReturnName");
                PageTextBoxEnter(PageLocator, EditFirstName, OldFirstNameProfile);
                PageTextBoxEnter_Enter(PageLocator, EditLastName, OldLastNameProfile);
                logger.Debug("Succsses ReturnName");
                return true;
            }
            else
            {
                logger.Debug("Failed ReturnName");
                return false;
            }
        }
        public bool AccountSettings()
        {
            logger.Debug("Click AccountSettings");
            bool test = PageButtonClick(PageLocator, AccountSettingsLocator);
            if (test)
            {
                logger.Debug("Succsses Click AccountSettings");
                return true;
            }
            else
            {
                logger.Debug("Failed Click AccountSettings");
                return false;
            }
        }
    }
}
