Feature: OracleHRNavigation-EmployeeViews
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Oracle HR Navigation - Employee Views
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HR Operations Self Service" option
	And click the "Employee Overview" option
	Then I view the employee information
