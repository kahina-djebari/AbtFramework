Feature: KnowledgeHubLandingPage

@LandingPage
Scenario: Knowledge Hub is available
	Given  Knowledge Hub loads successsfully 
Scenario: Project and project files related link
	Given i click on project and project file link
	Then  project and project files page loads successfully
Scenario: Proposals and proposal files promoted link
	Given i click on Proposals and proposal file link
	Then  project and project files page loads successfully
Scenario: RepCap & RepCap page files is available
    Given i click on RepCap & RepCap file link
	Then  RepCap & RepCap files page loads successfully