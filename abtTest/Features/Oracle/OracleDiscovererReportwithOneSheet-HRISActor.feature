Feature: OracleDiscovererReportWithOneSheet-HRISActor
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Oracle Discoverer Report With One Sheet - HRIS Actor
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt US HR Manager" option
	And click the "Discoverer Viewer" option
	Then I do discoverer books for one sheet

