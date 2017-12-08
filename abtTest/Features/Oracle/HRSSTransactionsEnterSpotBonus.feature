Feature: HRSSTransactionsEnterSpotBonus
	In order to complete a HRSS Transactions -Enter
	Spot Bonus - Actor HRSC

@Oracle
Scenario: HRSS Transactions -Enter Spot Bonus - Actor HRSC
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HR Operations Self Service" option
	Then click the "Spot Bonus" option 
	Then I enter Spot Bonus