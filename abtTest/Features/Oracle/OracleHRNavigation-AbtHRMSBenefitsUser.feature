Feature: OracleHRNavigation-AbtHRMSBenefitsUser
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Oracle HR Navigation - Abt HRMS Benefits User
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Benefits User" option
	And click the "Enter and Maintain" option
	Then I update information on the oracle form
