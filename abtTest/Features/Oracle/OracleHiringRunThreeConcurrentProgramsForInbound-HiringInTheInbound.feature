Feature: OracleHiringRunThreeConcurrentProgramsForInbound-HiringInTheInbound
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Oracle Hiring - Run Three Concurrent Programs For Inbound - Hiring In The Inbound
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt US HRMS Manager" option
	And click the "View Requests" option
	Then I perform hiring in the inbound
