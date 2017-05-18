Feature: Facilities
	In order to create an Incident Response report
	As a Security It user
	I want to be able to create the IR report from scratch or from a previously reported Incident.

@IRR
Scenario: Create a Facility Request
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Anna Piacitelli"
	And I have opened Facilities
	When I Create a facilities request With Category "Cleaning" and Subcategory "Windows" and assignment grp "Office Services - Bethesda"
	And I click ready for work
	Then facilities request should have been created

Scenario: Process Facility Request
	Given I have Open Chrome
	And I have navigated to ServiceNow Home Page
	And I have impersonated user "Steve Hunt"
	And Under the facilites section i click on Assigned to me and click a ticket
	And I click start work to start procesing the ticket
	When im done with the ticket i click Close Complete
	Then facilities request should have been closed