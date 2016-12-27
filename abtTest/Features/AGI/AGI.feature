Feature: AGI
	In order to ensure successfull AGI Funcionality
	As an Abt User
	I want to be able to navigate and open links and documents on AGI

@AGI
Scenario: Check Oracle on QuickLinks
	Given I have Open IE
	And I have navigated to AGI Home Page
	When I Hover over Quick Links
	And I Click on Oracle
	Then The Oracle Home Page Should Load Succesfully

Scenario: Check Staff Directory on QuickLinks
	Given I have Open IE
	And I have navigated to AGI Home Page
	When I Hover over Quick Links
	And I Click on Staff Directory
	Then I should be redirected to a page where you can Search the Staff people

