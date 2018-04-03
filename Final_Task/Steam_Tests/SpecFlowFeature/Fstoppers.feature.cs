﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Steam_Tests.SpecFlowFeature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Fstoppers", Description="\tPrecondition: there is a user on steam (previously created by hands), the user i" +
        "s logged on steam", SourceFile="SpecFlowFeature\\Fstoppers.feature", SourceLine=0)]
    public partial class FstoppersFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Fstoppers.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Fstoppers", "\tPrecondition: there is a user on steam (previously created by hands), the user i" +
                    "s logged on steam", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 5
 testRunner.Given("First Opened main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Given("Enter the site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verifying the change of user name", new string[] {
                "tag"}, SourceLine=8)]
        public virtual void VerifyingTheChangeOfUserName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verifying the change of user name", new string[] {
                        "tag"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 10
 testRunner.Given("Click on the profile icon in the upper right corner, select the Edit Profile drop" +
                    "-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.When("Change the name and surname: fill in the input fields with new passwords, save th" +
                    "e changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("Check the values on the opened profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.When("Return default values name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("Close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check password change", new string[] {
                "tag"}, SourceLine=16)]
        public virtual void CheckPasswordChange()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check password change", new string[] {
                        "tag"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 18
 testRunner.Given("Click on the profile icon in the upper right corner, select the Edit Profile drop" +
                    "-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When("Click on the button \"Account Settings\" under the profile photo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
  testRunner.And("Change the password: fill in the input fields with the old and new password, save" +
                    " the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
  testRunner.And("Click on the profile icon in the upper right corner, select the Logout Out drop-d" +
                    "own menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("Enter the site with a new password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("Return default values password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("Close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check group entry", new string[] {
                "tag"}, SourceLine=26)]
        public virtual void CheckGroupEntry()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check group entry", new string[] {
                        "tag"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 28
 testRunner.When("On the panel at the top of the site, point to Groups, click Join to the first gro" +
                    "up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
  testRunner.And("Click on Groups, and go to the page with groups", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.Then("Check whether the status in the group has changed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.Then("Close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check the news", new string[] {
                "tag"}, SourceLine=33)]
        public virtual void CheckTheNews()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the news", new string[] {
                        "tag"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 35
 testRunner.Given("In the news panel, select the ORIGINALS tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.When("Go to the page with the first news", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("Compare the name of the news", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.Then("Close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Checking the Search", new string[] {
                "tag"}, SourceLine=40)]
        public virtual void CheckingTheSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checking the Search", new string[] {
                        "tag"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 42
 testRunner.Given("On the panel at the top of the site, Articles, click Browse all categories", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.When("Choose Nature", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
  testRunner.And("Remember the name of the author of the first publication, and enter in the search" +
                    " field the reference at the top of the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.Then("Click on the Members tab, check the author\'s profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.Then("Close browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
