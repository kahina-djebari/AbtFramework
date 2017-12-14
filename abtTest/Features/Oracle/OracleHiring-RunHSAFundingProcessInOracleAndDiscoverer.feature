Feature: OracleHiring-RunHSAFundingProcessInOracleAndDiscoverer
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Oracle Hiring - Run HSA Funding Process In Oracle And Discoverer
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HRMS Benefits User" option
	And click the "Submit Processes and Reports" option
	Then I submit a report
