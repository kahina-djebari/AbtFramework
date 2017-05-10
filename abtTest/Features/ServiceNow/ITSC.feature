Feature: ITSC
    In order to create an Incidents
	As a IT Services user
	I want to be able to create, process and close incidents

@ITSC
Scenario: Create ITSC Incident from Scratch
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Irving Anglon"
	And As an ITSC i open Incident Section
    When As an ITSC I Create an Incident With Category "Software" and Subcategory "Application" and Type "Failure"
	Then The ITSC Incident Report should have been created

Scenario: Process an ITSC incident from Scratch
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Irving Anglon"
	Then ITSC Opens and Process the Incident