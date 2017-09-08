Feature: SSO
	In order to validate that user is able to log in automatically with Okta SSO	
	As an Abt user
	I want to navigate to every Okta App web home page and get the response time

@SSO
Scenario: Should get AGI Response Time
	Given I have Open IE
	And I have navigated to AGI Home Page
	When The Home page completes loading
	Then I Should be able to calculate what the response time is

Scenario: Should get SuccessFactors Response Time
	Given I have Open IE
	And I have navigated to AGI-Tools&Resources
	And I Click on Abt Talent, Learning and Support (ATLAS)
	And I wait for the SuccessFactor Home Page to load
	Then I Should be able to calculate what the SuccessFactor Home Page response time is

Scenario: Should get Abt Travel Booking Response Time
	Given I have Open IE
	And I have navigated to AGI-Tools&Resources
	And I Click on AbtTravel Online Booking
	And I wait for the AbtTravel Online Booking Home Page to load
	Then I Should be able to calculate what the AbtTravel Home Page response time is

Scenario: Should get AbtXchange response time

	Given I have Open IE
	And I have navigated to AGI Home Page
	And I Click on AbtXchange
	And I wait for the AbtXchange Home Page to load
	Then I Should be able to calculate what the AbtXchange Home Page response time is

Scenario: Should get Ebsco Response time

	Given I have Open IE
	And I have navigated to AGI-Tools&Resources
	And I Click on Abt Research Library
	And I Click on Ebsco Discovery Service
	And I wait for the Ebsco Home Page to load
	Then I should be able to calculate what the Ebsco Home Page response time is

Scenario: Should get RightFind Response time

	Given I have Open IE
	And I have navigated to AGI-Tools&Resources
	And I Click on Abt Research Library
	And I Click on the RightFind Link Named Document Delivery via Copyright Clearance Center | RightFind
	And I wait for the RightFind Home Page to load
	Then I should be able to calculate what the RightFind Home Page response time is

Scenario: Should get ServiceNow Response time

	Given I have Open IE
	When I navigate to ServiceNow Home Page
	And I wait for the ServiceNow Home page to load
	Then I Should be able to calculate what the ServiceNow Home Page response time is

Scenario: Should get WebEx Response Time

	Given I have Open IE
	When I navigate to WebEx Home Page
	And I Click Log In
	And I wait For the WebEx Home page to load
	Then I Should be able to calculate what the WebEx home page response time is

Scenario: Should get Oracle Response Time
	Given I have Open IE
	And I have navigated to AGI-Tools&Resources
	And I Click on Oracle
	Then The Oracle Home Page Should Load Succesfully