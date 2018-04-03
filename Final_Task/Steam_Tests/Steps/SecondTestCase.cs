using System;
using TechTalk.SpecFlow;
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
using Steam_Tests.Pages;

namespace Steam_Tests.Steps
{
    [Binding]
    public class FstoppersSteps1
    {
        [When(@"Click on the button ""(.*)"" under the profile photo")]
        public void ClickOnTheButtonUnderTheProfilePhoto(string p0)
        {
            EditProfilePage Edit_Profile_page = new EditProfilePage();
            Edit_Profile_page.AccountSettings();
        }

        [When(@"Change the password: fill in the input fields with the old and new password, save the changes")]
        public void Change_Password_Save_Changes()
        {
            AccountSettingsPage Account_Settings = new AccountSettingsPage();
            Account_Settings.ChangePassword();
        }

        [When(@"Click on the profile icon in the upper right corner, select the Logout Out drop-down menu")]
        public void Select_Logout()
        {
            AccountSettingsPage Account_Settings = new AccountSettingsPage();
            Account_Settings.Logaut();
        }

        [When(@"Return default values password")]
        public void Return_Default_Values_Password()
        {
            HomePage Home_page = new HomePage();
            AccountSettingsPage Account_Settings = new AccountSettingsPage();
            EditProfilePage Edit_Profile_page = new EditProfilePage();
            Home_page.EditProfile();
            Edit_Profile_page.AccountSettings();
            Account_Settings.ReturnPassword();
        }

        [Then(@"Enter the site with a new password")]
        public void Enter_Site_With_New_Password()
        {
            HomePage Home_page = new HomePage();
            Home_page.LoginButton();
            Home_page.NewLogin();
        }
    }
}
