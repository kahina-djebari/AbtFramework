Feature: AccountingPayableDefiningDistribtionSet
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Accounting Payable: Defining Distribtion Set
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "PRTEST01"
	Then click the "Abt US AP Superuser" option
	And click the "Distribution Sets" option
	Then I define Distribution Set
