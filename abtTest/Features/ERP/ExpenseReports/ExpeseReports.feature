Feature: ExpeseReports
	entering and submitting the expense report.

@ExpeseReports
Scenario: entering and submitting the expense report.
	Given i Login to Jamis with a valid URL and User credentials
	Then  Go to Expense Reports
	And   When the menu loads go to the Expenses creation screen
	And   Create a new Expense Report
	When  the detail expense report loads fill the description and detailed descruption duelds
	Then  Enter the expense incurred Date 
	And   Add the location code
	And   Add Per Diem details in the Expense Report
	Given I Distribute the expense report to different jobs
	When  Submit the Expenses report should submit successfully

