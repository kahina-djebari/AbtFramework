Feature: HRSSTransactionsEnterInvoluntaryOffboarding
	In order to complete a HRSS Transactions -Enter
	Involuntary Offboarding - Actor HRBP

@Oracle
Scenario: HRSS Transactions -Enter Involuntary Offboarding - Actor HRBP
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HR Operations Self Service" option
	Then click the "Offboard Employee" option 
	Then I enter involuntary offboarding