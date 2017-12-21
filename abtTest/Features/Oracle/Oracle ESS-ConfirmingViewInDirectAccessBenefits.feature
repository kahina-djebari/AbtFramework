Feature: OracleESS-ConfirmingViewInDirectAccessBenefits
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: Oracle ESS - Confirming View In Direct Access Benefits
	Given I have Open Chrome Test
	And I have navigated to Oracle Dev
	And i login as "oumsalems"
	Then click the "Abt US Employee Direct Access" option
	And click the "Benefits" option
	Then I confirm view and add beneficiaries
