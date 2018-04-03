using Steam_Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Steam_Tests.Steps
{
    [Binding]
    public class FstoppersSteps2
    {
        [When(@"On the panel at the top of the site, point to Groups, click Join to the first group")]
        public void Point_To_Groups_Click_Join_To_The_First_Group()
        {
            HomePage Home_page = new HomePage();
            Home_page.ClickGroupAndJoin();
        }
        
        [When(@"Click on Groups, and go to the page with groups")]
        public void Go_To_Page_Groups()
        {
            HomePage Home_page = new HomePage();
            Home_page.GroupButtonClick();
        }
        
        [Then(@"Check whether the status in the group has changed")]
        public void Check_Status_Group_Changed()
        {
            GroupsPage Groups_Page = new GroupsPage();
            Groups_Page.ClickGroupSuccess();
        }
    }
}
