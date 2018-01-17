Feature: AccountingPayableEnteringInvoicesInInvoiceWorkbench
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Accounting Payable: Entering Invoices In Invoice Workbench
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "PRTEST01"
	Then click the "Abt US AP Superuser" option
	Then I Enter an Invoice in Invoice Workbench
