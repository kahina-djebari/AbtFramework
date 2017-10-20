Feature: Oracle
		In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@oracle
Scenario: Abt US Employee Direct Access
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Valerie Hennessey"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Employee Self Service Actions Awaiting Your Attention"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Personal Information"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Extra Information"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Benefits"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Voluntary Disclosure of Disability"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Voluntary Disclosure of Veterans Status"

Scenario: Abt US Projects Inquiry Access
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Valerie Hennessey"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Notifications"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Abt PO Details"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Project"
	Then click the "Abt US Projects Inquiry" option
	And browse to "All"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Project Status Inquiry"
	Then click the "Abt US Projects Inquiry" option
	And browse to "View Project Information"
	Then click the "Abt US Projects Inquiry" option
	And browse to "View Contract Information"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Agreements"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Control Billing by Top Task"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Revenue Review"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Invoice Review"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Funding Inquiry"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Profile"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Concurrent"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Run"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Set"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Purchase Order Summary"

Scenario: iProcurement Request
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Sofiane Oumsalem"
	Then click the "Abt US iProcurement Requester" option
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

Scenario:Requisition approval 
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Gail Berg"
	Then click the "Abt US iProcurement Inquiry" option
	And complete the order

Scenario:Timecard vacations Request
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Sofiane Oumsalem"
	Then click the "Abt US Timecards" option
	And go to time entry
	And fill the TimeCard
	Then close complete the timeCard request
	
Scenario:Approve Timecard
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Mauricio Poodts"
	And go to the Home screen
	Then click the "Abt US iProcurement Inquiry" option
	And complete the order