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
  
Scenario: Check Forms Library on QuickLinks
	Given I have Open IE
	And I have navigated to AGI Home Page
	When I Hover over Quick Links
	And I Click on Forms Library
	Then I should be redirected to the AbtForms Library Page

Scenario: Check Customize Link on QuickLinks
	Given I have Open IE
	And I have navigated to AGI Home Page
	When I Hover over Quick Links
	And I Click on Customize
	Then I should be redirected to the Personal Links Page

Scenario: Check "Today I Learned" Link
	Given I have Open IE
	And I have navigated to AGI Home Page
	When I Click on "Today I Learned" to Open an insight
	Then The detailed page about the insight should load

Scenario: Check Abt Events Calendar
	Given I have Open IE
	And I have navigated to AGI Home Page
	When I Click on "See More" under the Abt Events Section
	Then The Abt Events Calendar should display

Scenario: Check "About Abt" Page
	Given I have Open IE
	And I have navigated to AGI Home Page
	When I Hover over "Home" on the Mega Menu
	And I click on About Abt
	Then The About Abt page Should display

Scenario: Check Left Navigation on About Abt Page
	Given I have Open IE
	And I have navigated to the "About Abt" page on AGI
	When I Click on "We Are Abt" on the Left panel
	Then The "We Are Abt" section should display
	And The breadcrumbs on the page should display the path to "We Are Abt"
	And If I Click on "Elevator Speech" on the Left panel
	Then The "Elevator Speech" section should display
	And The breadcrumbs on the page should display the path to "Elevator Speech"
	And If I Click on "Management Advisory Group" on the Left panel
	Then The "Management Advisory Group" section should display
	And The breadcrumbs on the page should display the path to "Management Advisory Group"
	And If I Click on "Office Locations" on the Left panel
	Then The "Office Locations" section should display
	And The breadcrumbs on the page should display the path to "Office Locations"
	And If I Click on "Bethesda" on the Left panel
	Then The "Bethesda" section should display
	And The breadcrumbs on the page should display the path to "Bethesda"
	And If I Click on "Cambridge" on the Left panel
	Then The "Cambridge" section should display
	And The breadcrumbs on the page should display the path to "Cambridge"
	And If I Click on "Abt Cafe at Cambridge" on the Left panel
	Then The "Abt Cafe at Cambridge" section should display
	And The breadcrumbs on the page should display the path to "Abt Cafe at Cambridge"
	And If I Click on "Abt Cambridge Softball" on the Left panel
	Then The "Abt Cambridge Softball" section should display
	And The breadcrumbs on the page should display the path to "Abt Cambridge Softball"
	And If I Click on "Cambridge Shuttle Schedule" on the Left panel
	Then The "Cambridge Shuttle Schedule" section should display
	And The breadcrumbs on the page should display the path to "Cambridge Shuttle Schedule"
	And If I Click on "Durham" on the Left panel
	Then The "Durham" section should display
	And The breadcrumbs on the page should display the path to "Durham"
	And If I Click on "History" on the Left panel
	Then The "History" section should display
	And The breadcrumbs on the page should display the path to "History"

