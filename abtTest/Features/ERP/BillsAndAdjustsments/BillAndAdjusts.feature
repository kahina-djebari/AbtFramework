Feature: BillAndAdjusts
	Accounts PayableBill Regression Scenarios

@BillsAndAdjustments
Scenario: Entering a Bill in the Base Currency
	Given i Login to Jamis with a valid URL and User credentials
	Then  click on Finance
	And   then  Click Account Payable
	And   under Enter click Bills And Adjustments
	When  the Checks and Payment menu appears click Add New Record 
	Then  select Bill as type 
	And   the status should be on hold with the check box checked
	And   Enter the bill date and check the post period text box
	Then  Select the Vendor the invoice is from
	And   Enter the ref # in Vendor Ref text box
	Then  Enter the description in the description text box 
	And   hit the plus icon under document details 
	Then  i choose an incurDate_JobID_LaborCat_CostElem_Organization_CostElem_Loc
	When  i click save the status its updated to Open
