Feature: OracleESS-ConfirmingViewAndUpdateInDirectAccessBenefits
	    In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@Oracle
Scenario: OracleESS - Confirming View And Update In Direct Access Benefits
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Sofiane Oumsalem"
	Then click the "Abt US Employee Direct Access" option
	And click the "Personal Information" option
	Then I confirm and update personal information 
