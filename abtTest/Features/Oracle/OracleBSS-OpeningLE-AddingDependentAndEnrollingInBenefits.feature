Feature: OracleBSS-OpeningLE-AddingDependentAndEnrollingInBenefits
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: OracleBSS - OpeningLE - Adding Dependent And Enrolling In Benefits
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Benefits User" option
	And click the "Benefits Service Center" option
	Then I add life event and enroll in benefits
