using Steam_Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Steam_Tests.Steps
{
    [Binding]
    public class FstoppersSteps4
    {
        [Given(@"On the panel at the top of the site, Articles, click Browse all categories")]
        public void Click_Browse_All_Categories()
        {
            HomePage Home_page = new HomePage();
            Home_page.ClickArticlesAndClickAll();
        }
        
        [When(@"Choose Nature")]
        public void Choose_Nature()
        {
            CategoriesPage Categories_Page = new CategoriesPage();
            Categories_Page.NativeButton();
        }
        
        [When(@"Remember the name of the author of the first publication, and enter in the search field the reference at the top of the page")]
        public void Remember_Name_Author_First_Publication_And_Enter_In_Search()
        {
            NativePage Native_Page = new NativePage();
            Native_Page.SearchName();
        }
        
        [Then(@"Click on the Members tab, check the author's profile")]
        public void Click_On_Members_Tab_Check_AuthorS_Profile()
        {
            NativePage Native_Page = new NativePage();
            Native_Page.SearchNameChecked();
        }
    }
}
