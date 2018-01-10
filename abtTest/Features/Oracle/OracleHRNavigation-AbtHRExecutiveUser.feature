Feature: OracleHRNavigation-AbtHRExecutiveUser
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Oracle HR Navigation - Abt HR Executive User
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt US HR Executive" option
	And click the "Enter and Maintain" option
	Then I go to Office Details on the oracle form
	And click the "Abt US HR Executive" option
	Then click the "Discoverer Viewer" option
