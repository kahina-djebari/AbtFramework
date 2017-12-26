Feature: Oracle
		In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test


@Oracle
Scenario: Abt US Employee Direct Access
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "oumsalems"
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

	@Oracle
Scenario: Abt US Projects Inquiry Access
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "PCTEST01"
	Then click the "Abt US Projects Inquiry" option
	Then I click on all links at the right side menu

	@Oracle
Scenario: iProcurement Request
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "oumsalems"
	Then click the "Abt US iProcurement Requester" option
	Then click iProcurement request and then Non-Catalog Req
	And fill the request form
	Then Checkout the cart
	And Fill Requisition Information
	And Then assign "Elguera, Jorge L" after requisition and submit
	And Then assign "Samuel, Noel N" after requisition and submit
	Then Submit after approvers
	When i hit submit the request is done

	@Oracle
Scenario:Requisition approval 
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "ElgueraJ"
	Then click the "Abt US iProcurement Inquiry" option
	And complete the order

	@Oracle
Scenario:Timecard vacations Request
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "oumsalems"
	Then click the "Abt US Timecards" option
	And go to time entry
	And fill the TimeCard
	Then close complete the timeCard request
	
	@Oracle
Scenario:Approve Timecard
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "ElgueraJ" 
	Then click the "Abt US iProcurement Inquiry" option
	And complete the order


	@Oracle
Scenario:Creation and approval of PO
    Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "KruckM"
	Then click the "Abt US PO Buyer" option
	And browse to Requisitions under Buyer Work Center
	Then select a requisition to add
	And click Add and Create



	@Oracle
Scenario: Purchasing Request
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "KruckM"
	Then click the "Abt US PO Buyer" option
	And browse to Requisitions under Requisitions
	Then I fill the Oracle Forms


	@Oracle
Scenario: Abt Employee Roster
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt Employee Roster" option

	@Oracle
Scenario: Abt HR Desktop Integration
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HR Desktop Integration" option
	Then I click on all links at the right side menu	
	

	@Oracle
Scenario: Abt HR Operations Self Service
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HR Operations Self Service" option
	Then I click on all links at the right side menu		
	

	@Oracle
Scenario: Abt HR System Administrator
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HR System Administrator" option
	Then I click on all links at the right side menu	
	

	@Oracle
Scenario: Abt HR User
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HR User" option
	Then I click on all links at the right side menu		
	

	@Oracle
Scenario: Abt HRMS Benefits User
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Benefits User" option
	Then I click on all links at the right side menu	

	@Oracle
Scenario: Abt HRMS Superuser
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Superuser" option
	Then I click on all links at the right side menu	


	@Oracle
Scenario: Abt HRMS User
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS User" option
	Then I click on all links at the right side menu	

	@Oracle
Scenario: Abt US HR Executive
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt US HR Executive" option
	Then I click on all links at the right side menu	
	

	@Oracle
Scenario: Abt US HR Manager
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt US HR Manager" option
	Then I click on all links at the right side menu 
	

	@Oracle
Scenario: US Super HRMS Manager
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "US Super HRMS Manager" option	
	Then I click on all links at the right side menu			 	
		
	@Oracle
	Scenario: US HRMS Manager
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "US HRMS Manager" option	
	Then I click on all links at the right side menu				

	@Oracle
Scenario: US HR Manager
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "US HR Manager" option
	Then I click on all links at the right side menu		

	@Oracle
Scenario: Abt US HR Technical Manager
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt US HR Technical Manager" option
	Then I click on all links at the right side menu		

	@Oracle
Scenario: Abt US HRMS Manager
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt US HRMS Manager" option
	Then I click on all links at the right side menu					
	
	@Oracle
Scenario: HR: Manage Employee Action Forms
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "HR: Manage Employee Action Forms" option
	Then I click on all links at the right side menu	


	@Oracle
Scenario: Workflow User Web Applications
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Workflow User Web Applications" option
	Then I click on all links at the right side menu	

