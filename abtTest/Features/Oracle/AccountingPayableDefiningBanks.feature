Feature: AccountingPayableDefiningBanks
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Accounting Payable: Defining Banks
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "PRTEST01"
	Then click the "Abt US AP Superuser" option
	And click the "	Bank Accounts" option
	Then I create a bank account
	
