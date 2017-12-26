Feature: OracleTermination-ConfirmingTermedEmployeeBenefitProcessSuccess
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Oracle Termination - Confirming Termed Employee Benefit Process Success
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Benefits User" option
	And click the "Benefits Service Center" option
	Then I confirm termed employee benefit process success
