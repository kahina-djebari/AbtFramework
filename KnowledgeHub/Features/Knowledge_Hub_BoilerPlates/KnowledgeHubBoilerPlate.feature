Feature: KnowledgeHubBoilerPlate

@BoilerPlatePage
Scenario: Edit Boilerplate documents online
	Given i right click a row of the central boilerplate
	And   then i hit edit in word online
	When  the document loads i type my name 
	Then  i know i can edit documents online
