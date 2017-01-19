Feature: BillAndAdjusts
	Accounts PayableBill Regression Scenarios

@BillsAndAdjustments
Scenario: Entering a Bill in the Base Currency
	Given i Login to Jamis with a valid URL and User credentials	
	Then  click on Finance, Click Account Payable Then under Enter Bills And Adjustments
	Then  Fill the international Vendor information
	Then  Add New Record 
	And   fill the Document information
	Then  i click save the status its updated to Open
	When  a reference nbr is generated i release the bill
