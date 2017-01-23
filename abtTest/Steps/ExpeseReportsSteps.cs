using System;
using AbtFramework;
using AbtFramework.Utils_Classes;
using Xunit;
using TechTalk.SpecFlow;

namespace abtTest.Steps
{
    [Binding]
    public class ExpeseReportsSteps
    {
        [Given(@"I Distribute the expense report to different jobs")]
        public void GivenIDistributeTheExpenseReportToDifferentJobs()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the detail expense report loads fill the description and detailed descruption duelds")]
        public void WhenTheDetailExpenseReportLoadsFillTheDescriptionAndDetailedDescruptionDuelds()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Submit the Expenses report should submit successfully")]
        public void WhenSubmitTheExpensesReportShouldSubmitSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Go to Expense Reports")]
        public void ThenGoToExpenseReports()
        {
            AbtPages.ERPExpenseReports.TimeAndExpensesSideMenu("ExpenseReports");
        }
        
        [Then(@"When the menu loads go to the Expenses creation screen")]
        public void ThenWhenTheMenuLoadsGoToTheExpensesCreationScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Create a new Expense Report")]
        public void ThenCreateANewExpenseReport()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Enter the expense incurred Date")]
        public void ThenEnterTheExpenseIncurredDate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Add the location code")]
        public void ThenAddTheLocationCode()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Add Per Diem details in the Expense Report")]
        public void ThenAddPerDiemDetailsInTheExpenseReport()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
