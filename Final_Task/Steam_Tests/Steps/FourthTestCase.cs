using Steam_Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Steam_Tests.Steps
{
    [Binding]
    public class FstoppersSteps3
    {
        [Given(@"In the news panel, select the ORIGINALS tab")]
        public void Select_ORIGINALS_Tab()
        {
            HomePage Home_page = new HomePage();
            Home_page.CheckOriginals();
        }
        
        [When(@"Go to the page with the first news")]
        public void Go_To__Page_First_News()
        {
            HomePage Home_page = new HomePage();
            Home_page.CheckNameNews();
            Home_page.GoToNews();
        }
        
        [Then(@"Compare the name of the news")]
        public void Compare_Name_News()
        {
            HomePage Home_page = new HomePage();
            Home_page.IsNewsNameChecked();
        }
    }
}
