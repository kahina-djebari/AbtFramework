Feature: KnowldegHubProjectPage 

@ProjectPage
Scenario: Active projects information are available and editable
	Given i go to active projects and click a project number 
	And   the details belong to the project number i selected
	When  i click edit at the top left corner
	And   i validate the project number is still the same
	Then  i click on isActive to confirm i cant edit it
	Then  i click on Global Abt Organization to confirm it is editable

@ProjectDetails
Scenario: Project descriptions are available and editable
	Given i click on a project description name
	And   i have validated project number and description are correct
	When  i click on Edit
	And   after i click the Description Title
	Then  if i can type the field its editable

Scenario: Project Name and Number are automatically populated when uploading files
	Given i click upload files
	And   choose a new files to be uploaded
	When  click OK
	Then  the project name and number are populated correctly




	

