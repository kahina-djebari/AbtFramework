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
namespace abtTest.Features.Oracle
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("HRSSTransactions-ApproveHRTransactionsSpotBonus-ChangeHours-SupervisorTimecardApp" +
        "rover", Description="\t    In order to Ensure the Estability of\r\n\t\tOur ERP\r\n\t\tI Want To Perform a Funct" +
        "ioal Test", SourceFile="Features\\Oracle\\HRSSTransactions-ApproveHRTransactionsSpotBonus-ChangeHours-Super" +
        "visorTimecardApprover.feature", SourceLine=0)]
    public partial class HRSSTransactions_ApproveHRTransactionsSpotBonus_ChangeHours_SupervisorTimecardApproverFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HRSSTransactions-ApproveHRTransactionsSpotBonus-ChangeHours-SupervisorTimecardApprover.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "HRSSTransactions-ApproveHRTransactionsSpotBonus-ChangeHours-SupervisorTimecardApp" +
                    "rover", "\t    In order to Ensure the Estability of\r\n\t\tOur ERP\r\n\t\tI Want To Perform a Funct" +
                    "ioal Test", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("HRSS Transactions - Approve HR Transactions Spot Bonus - Change Hours - Superviso" +
            "r Timecard Approver", new string[] {
                "Oracle"}, SourceLine=6)]
        public virtual void HRSSTransactions_ApproveHRTransactionsSpotBonus_ChangeHours_SupervisorTimecardApprover()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HRSS Transactions - Approve HR Transactions Spot Bonus - Change Hours - Superviso" +
                    "r Timecard Approver", new string[] {
                        "Oracle"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have Open IE Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("I have navigated to Oracle Dev", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("i login as \"HRTEST01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("click the \"Workflow User Web Applications\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.And("click the \"Worklist\" option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.Then("I approve the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
