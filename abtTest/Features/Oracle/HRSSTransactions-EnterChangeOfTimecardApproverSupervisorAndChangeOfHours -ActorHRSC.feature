Feature: HRSSTransactions-EnterChangeOfTimecardApproverSupervisorAndChangeOfHours -ActorHRSC
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: HRSS Transactions - Enter Change of Timecard ApproverSupervisor and Change of Hours - Actor HRSC
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HR Operations Self Service" option
	And click the "Change Timecard Approver and Supervisor" option
	Then change timecard approver
	Then click the "Abt HR Operations Self Service" option
	And click the "Change of Hours" option
	Then I change the employee hours

