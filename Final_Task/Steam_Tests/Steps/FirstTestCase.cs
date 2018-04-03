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
    public class FstoppersSteps
    {
        [Given(@"First Opened main page")]
        public void First_Opened_Main_Page()
        {
            BasePage.Driver = null;
            HomePage Home_page = new HomePage();
            Home_page.PageGo(Home_page.UrlHomePage, Home_page.PageLocator);
        }
        
        [Given(@"Enter the site")]
        public void Enter_The_Site()
        {
            HomePage Home_page = new HomePage();
            Home_page.LoginButton();
            Home_page.LoginClick();
        }
        
        [Given(@"Click on the profile icon in the upper right corner, select the Edit Profile drop-down menu")]
        public void Select_EditProfile()
        {
            HomePage Home_page = new HomePage();
            Home_page.EditProfile();
        }
        
        [When(@"Change the name and surname: fill in the input fields with new passwords, save the changes")]
        public void Change_Name_And_Surname_Save_Changes()
        {
            EditProfilePage Edit_Profile_page = new EditProfilePage();
            Edit_Profile_page.ChangeName();
        }
        
        [When(@"Return default values name")]
        public void Return_Default_Values()
        {
            HomePage Home_page = new HomePage();
            EditProfilePage Edit_Profile_page = new EditProfilePage();
            Home_page.PageGo(Home_page.UrlHomePage, Home_page.PageLocator);
            Home_page.EditProfile();
            Edit_Profile_page.ReturnName();
        }
        
        [Then(@"Check the values on the opened profile page")]
        public void Check_Values_On_ProfilePage()
        {
            ProfilePage Profile_page = new ProfilePage();
            Profile_page.IsChangeNameSuccess();
        }

        [Then(@"Close browser")]
        public void Close_Browser()
        {
            BasePage.Driver.Quit();
        }

    }
}
