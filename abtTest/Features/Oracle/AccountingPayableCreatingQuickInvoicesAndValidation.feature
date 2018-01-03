Feature: AccountingPayableCreatingQuickInvoicesAndValidation
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Accounting Payable: Creating Quick Invoices And Validation 
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "PRTEST01"
	Then click the "Abt US AP Superuser" option
	And I create and validate a quick invoice with the oracle form
