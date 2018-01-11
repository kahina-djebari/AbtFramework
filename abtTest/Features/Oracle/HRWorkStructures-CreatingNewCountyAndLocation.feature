Feature: HRWorkStructures-CreatingNewCountryAndLocation
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: HR WorkStructures: 1-Create the foreign payroll code
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Superuser" option
	And click the "Application Utilities Lookups" option
	Then I create the foreign payroll code

	@Oracle
Scenario: HR WorkStructures: 2-Create the Grades
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Superuser" option
	Then I create Grades

	@Oracle
Scenario: HR WorkStructures: 3-Create the Grades in the Salary Ranges Table
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Superuser" option
	Then click the "Grade Rate" option
	Then I create grades in salary range table

	@Oracle
Scenario: HR WorkStructures: 4-Link the New Grades to the Job Table for all INTL Jobs 
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Superuser" option
	Then I Link the New Grades to the Job Table for all INTL Jobs

	@Oracle
Scenario: HR WorkStructures: 5-Add the New Location to the Location Table
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Superuser" option
	Then click the "Location" option
	Then I Add the New Location to the Location Table