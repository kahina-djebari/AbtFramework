Feature: OracleBenefitsExtract-BenefitExtractRunsOnMonday
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Oracle Benefits Extract - Benefit Extract Runs On Monday
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt US HRMS Manager" option
	And click the "Extract Results" option
	Then Extract Results from the Oracle Form
