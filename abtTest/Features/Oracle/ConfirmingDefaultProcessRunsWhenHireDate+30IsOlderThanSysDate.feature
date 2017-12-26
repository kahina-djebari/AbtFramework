Feature: ConfirmingDefaultProcessRunsWhenHireDate+30IsOlderThanSysDate
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Confirming Default Process Runs When Hire Date +30 Is Older Than Sys Date
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "HRTEST01"
	Then click the "Abt HRMS Benefits User" option
	And click the "Benefits Service Center" option
	Then I confirm default process runs
