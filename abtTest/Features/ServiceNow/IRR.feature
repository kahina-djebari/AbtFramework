Feature: IRR
	In order to create an Incident Response report
	As a Security It user
	I want to be able to create the IR report from scratch or from a previously reported Incident.

@IRR
Scenario: Create Incident Response Report from Scratch
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Stella Laidoson"
	And I have opened Incident Response Report Section
	When I click on create new 
	And I fill the IRR form
	And I click submit
	Then Incident Response Report should have been created

Scenario: Create Incident Response Report from Parent Incident

	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Stella Laidoson"
	And I have opened Incident Section
	When I Create an Incident With Category "Security" and Subcategory "Event" and Type "Secure Email"
	And I try to Create an IRR from that Incident
	Then I Should be able to create an IR report from that Incident

Scenario: Should Only be able to Open one IRR per Incident

	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Stella Laidoson"
	And I have opened Incident Section
	When I Try To Create an IRR for an Open Security Incident that has already an IRR created
	Then I Should receive an error message stating a new IRR was not created

Scenario: Shouldn't Create IRR from Incompatible Incident
	
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Stella Laidoson"
	And I have opened Incident Section
	When I Create an Incident With Category "Systems Administration" and Subcategory "Network Folder" and Type "Permissions"
	Then I Should not be able to create an IR report from that Incident

Scenario: Should not be able to close an open IRR withouth filling all mandatory fields
	
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Stella Laidoson"
	And I have opened Incident Response Report Section
	When I Try to pull an IRR with state "Open" 
	And  I Change the IRR state to Closed Complete
	And  I Click Update
	Then I should receive an error indicating what fields are mandatory before closing

Scenario: Should not be able to close an open IRR withouth checking at least one box per section
	
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Stella Laidoson"
	And I have opened Incident Response Report Section
	When I Try to pull an IRR with state "Open" 
	And  I Change the IRR state to Closed Complete
	And  I Fill the IRR mandatory fields
	And  I Click Update
	Then I should receive an error indicating what boxes need to be checked before closing

Scenario: Should Close an Open IRR
	
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Stella Laidoson"
	And I have opened Incident Response Report Section
	When I Try to pull an IRR with state "Open" 
	And  I Change the IRR state to Closed Complete
	And  I Fill the IRR mandatory fields
	And  I Check all the required boxes on the IRR form
	And  I Click Update
	Then Incident Response Report should have been closed

