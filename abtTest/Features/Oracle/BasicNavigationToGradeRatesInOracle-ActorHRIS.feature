Feature: BasicNavigationToGradeRatesInOracle-ActorHRIS
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Basic Navigation To Grade Rates In Oracle - Actor HRIS
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HRMS Superuser" option
	And click the "Grade Rate" option
	Then I fill the Grade Rate Oracle Forms
	
