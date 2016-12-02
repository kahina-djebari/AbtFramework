Feature: IRR
	In order to create an Incident Response Report
	As an Security IT user
	I want to be able to create the IRR from scratch or from a previously reported Incident

@mytag
Scenario Outline: Create Incident Response Report from scratch
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user <user>
	And I have opened Incident Response Report Section
	When I click on create new 
	And I fill the IRR form
	And I click submit
	Then Incident Response Report should have been created

	

	Examples: 
	| user            |
	| Stella Laidoson |