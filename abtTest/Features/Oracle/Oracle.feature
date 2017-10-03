Feature: Oracle
		In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@oracle
Scenario: iProcurement Request
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Sofiane Oumsalem"
	Then click iProcurement request and then Non-Catalog Req
	And fill the request form
	Then Checkout the cart
	And Fill Requisition Information
	Then Click Manage Approvals
	And assign "Berg, Gail E" before requisition and submit
	And Then assign "Poodts, Mauricio" after requisition and submit
	And Then assign "Elguera, Jorge L" after requisition and submit
	And Then assign "Samuel, Noel N" after requisition and submit
	Then Submit after approvers
	When i hit submit the request is done

Scenario:Timecard vacations Request
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Sofiane Oumsalem"
	Then click Abt US Timecards
	And fill the TimeCard
	Then close complete the timeCard request
	