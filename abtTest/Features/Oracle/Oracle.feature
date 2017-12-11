Feature: Oracle
		In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test


@Oracle
Scenario: Abt US Employee Direct Access
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Sofiane Oumsalem"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Employee Self Service Actions Awaiting Your Attention"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Personal Information"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Extra Information"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Benefits"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Voluntary Disclosure of Disability"
	Then click the "Abt US Employee Direct Access" option
	And browse to "Voluntary Disclosure of Veterans Status"

	@Oracle
Scenario: Abt US Projects Inquiry Access
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Valerie Hennessey"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Notifications"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Abt PO Details"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Project"
	Then click the "Abt US Projects Inquiry" option
	And browse to "All"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Project Status Inquiry"
	Then click the "Abt US Projects Inquiry" option
	And browse to "View Project Information"
	Then click the "Abt US Projects Inquiry" option
	And browse to "View Contract Information"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Agreements"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Control Billing by Top Task"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Revenue Review"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Invoice Review"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Funding Inquiry"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Profile"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Concurrent"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Run"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Set"
	Then click the "Abt US Projects Inquiry" option
	And browse to "Purchase Order Summary"

	@Oracle
Scenario: iProcurement Request
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Sofiane Oumsalem"
	Then click the "Abt US iProcurement Requester" option
	Then click iProcurement request and then Non-Catalog Req
	And fill the request form
	Then Checkout the cart
	And Fill Requisition Information
	Then Click Manage Approvals
	And assign "Berg, Gail E" before requisition and submit
	And Then assign "Poodts, Mauricio" after requisition and submit
	And Then assign "Elguera, Jorge L" after requisition and submit
	And Then assign "Samuel, Noel N" after requisition and submit
	Then Submit after approvers
	When i hit submit the request is done

	@Oracle
Scenario:Requisition approval 
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Gail Berg"
	Then click the "Abt US iProcurement Inquiry" option
	And complete the order

	@Oracle
Scenario:Timecard vacations Request
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Sofiane Oumsalem"
	Then click the "Abt US Timecards" option
	And go to time entry
	And fill the TimeCard
	Then close complete the timeCard request
	
	@Oracle
Scenario:Approve Timecard
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Daniel Gunther" 
	Then click the "Abt US iProcurement Inquiry" option
	And complete the order


	@Oracle
Scenario:Creation and approval of PO
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Marlene Kruck"
	Then click the "Abt US PO Buyer" option
	And browse to Requisitions under Buyer Work Center
	Then select a requisition to add
	And click Add
	Then click Create


	@Oracle
Scenario: Purchasing Request
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Marlene Kruck"
	Then click the "Abt US PO Buyer" option
	And browse to Requisitions under Requisitions
	Then I fill the Oracle Forms


	@Oracle
Scenario: Abt Employee Roster
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt Employee Roster" option

	@Oracle
Scenario: Abt HR Desktop Integration
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HR Desktop Integration" option
	And click "Create Document" option
	And click "Define Layout" option
	And click "Define Mapping" option
	And click "Manage Document Links" option
	And click "Setup Options" option
	And click "Define Style Sheet" option
	

	@Oracle
Scenario: Abt HR Operations Self Service
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HR Operations Self Service" option
	And click "Employee Overview" option
	And click "Change of Hours" option
	And click "Change Timecard Approver and Supervisor" option
	And click "Spot Bonus" option
	And click "Offboard Employee" option
	And click "Notifications" option	
	

	@Oracle
Scenario: Abt HR System Administrator
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HR System Administrator" option
	And navigate to "Set"
	And navigate to "Values"
	And navigate to "Segments"
	And navigate to "Aliases"
	And navigate to "CrossValidation"
	And navigate to "Groups"
	And navigate to "Values"
	And navigate to "Accounts"
	And navigate to "Segments"
	And click on Values
	And navigate to "Run"
	And navigate to "Set"	
	

	@Oracle
Scenario: Abt HR User
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HR User" option
	And click "Discoverer Viewer" option
	And navigate to "Enter and Maintain"
	And navigate to "Hire Applicants"
	And navigate to "Enter Employees"
	And navigate to "Maintain Employees"
	And navigate to "Absence"
	And navigate to "Address"
	And navigate to "Application"
	And navigate to "Assignment"
	And navigate to "Basic Benefits"
	And navigate to "Contact"
	And navigate to "Employee Review"
	And navigate to "End Application"
	And navigate to "End Employment"
	And navigate to "Entries"
	And navigate to "Pay Method"
	And navigate to "Phones"
	And click "Salary Admin" option
	And navigate to "Salary History"
	And navigate to "Special Information"
	And navigate to "Requisition and Vacancy"
	And navigate to "Recruitment Activity"
	And navigate to "Applicant Quick Entry"	 
	And navigate to "Mass Update of Applicants"
	And navigate to "Schools & Colleges"
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Benefits"   
	And navigate to "Employee Assignment"
	And navigate to "Absence"
	And navigate to "Salary"
	And click on Entries
	And navigate to "People Folder"	 
	And navigate to "Assignment Folder"
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Employees by Organization"
	And navigate to "Employees by Element" 
	And navigate to "Employees by Absence Type"
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"
	And navigate to "View Requests"
	And navigate to "View Reports"	
	

	@Oracle
Scenario: Abt HRMS Benefits User
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HRMS Benefits User" option
	And navigate to "Enter and Maintain"
	And navigate to "Benefits Service Center"
	And navigate to "Hire Applicants"
	And navigate to "Enter Employees"
	And navigate to "Maintain Employees"
	And navigate to "Absence"
	And navigate to "Address"
	And navigate to "Application"
	And navigate to "Assignment"
	And navigate to "Basic Benefits"
	And navigate to "Contact"
	And navigate to "Employee Review"
	And navigate to "End Application"
	And navigate to "End Employment"
	And navigate to "Entries"
	And navigate to "Pay Method"	
	And click on People
	And navigate to "Phones"
	And navigate to "Previous Employment"
	And click "Salary Admin" option
	And navigate to "Salary History"
	And navigate to "Schools and College"	 
	And navigate to "Special Information"
	And navigate to "Requisition and Vacancy"
	And navigate to "Recruitment Activity"
	And navigate to "Applicant Quick Entry"
	And navigate to "Mass Update of Applicants"   
	And navigate to "Schools & Colleges"
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Benefits"
	And navigate to "Employee Assignment"	 
	And click on Absence
	And navigate to "Salary"
	And navigate to "Entries"
	And navigate to "People Folder"
	And navigate to "Assignment Folder" 
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Employees by Organization"
	And navigate to "Employees by Element"
	And navigate to "Employees by Absence Type"	 
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"   
	And navigate to "View Requests"
	And navigate to "View Reports"
	And navigate to "Batch Element Entry"
	And navigate to "BEE Summary"

	@Oracle
Scenario: Abt HRMS Superuser
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HRMS Superuser" option
	And navigate to "Enter and Maintain"
	And navigate to "Salary Management"
	And navigate to "Hiring Applicants"
	And navigate to "Entering Employees"
	And navigate to "Person Benefits Assignments"
	And navigate to "Mass Update of Applicant Assignments"
	And navigate to "Mass Update of Employee Assignments"
	And navigate to "Address"
	And navigate to "Assignment"
	And navigate to "Assignment Extra Information"
	And navigate to "Basic Benefits"
	And navigate to "Competence Profile"
	And navigate to "Contact"
	And navigate to "Employee Review"
	And navigate to "End Application"
	And navigate to "End Employment"	
	And navigate to "Entries"
	And navigate to "Pay Method"	
	And navigate to "Person Extra Information"
	And navigate to "Person Type Usage"	 
	And navigate to "Phones"
	And navigate to "Qualifications"
	And navigate to "Salary Review"
	And click "Salary Admin" option
	And navigate to "Salary History"
	And navigate to "Special Information"   
	And navigate to "Supplementary Roles"
	And navigate to "Previous Employment"
	And navigate to "School/College Attendance"
	And navigate to "Contact"
	And navigate to "Requisition and Vacancy"	 
	And navigate to "Recruitment Activity"
	And navigate to "Mass Update of Applicants"
	And navigate to "Request Recruitment Letter"
	And navigate to "Rating Scales"
	And navigate to "Competencies" 
	And navigate to "Competence Types"
	And navigate to "Competence Requirements"
	And navigate to "Schools & Colleges"
	And navigate to "Qualification Types"
	And navigate to "Assessment Template"	 
	And navigate to "Appraisal Template"
	And click "Upload Third Party Skills" option
	And click "Objectives Library" option
	And click "Performance Management Plans" option
	And navigate to "Location"   
	And navigate to "Status"
	And click on Description Organization
	And navigate to "Organization Manager"
	And click on Description Job
	And navigate to "Career Path Names"   
	And navigate to "Career Path"
	And navigate to "Job Group"
	And click on Description Grade
	And navigate to "Grade Rate"
	And click on Description Payroll   
	And navigate to "Element Description"
	And navigate to "Link"
	And navigate to "Salary Basis"
	And navigate to "Salary Survey"
	And navigate to "Benefit Contributions"   
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Accruals"
	And navigate to "Employee Benefits"
	And navigate to "Worker Assignment"   
	And navigate to "Absence"
	And navigate to "Salary"
	And click on Entries
	And navigate to "People Folder"
	And navigate to "Assignment Folder"   
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Employees by Organization"
	And navigate to "Employees by Position"
	And navigate to "Emps by Position Hierarchy"   
	And navigate to "Employees by Element"
	And navigate to "Employees by Absence Type"
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"
	And navigate to "View Requests"   
	And navigate to "View Reports"
	And click "Workflow Notifications" option
	And navigate to "Batch Element Entry"
	And navigate to "BEE Summary"
	And navigate to "Application Utilities Lookups"
	And navigate to "Define Cities"   
	And navigate to "User Profile Options"


	@Oracle
Scenario: Abt HRMS User
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HRMS User" option
	And navigate to "Enter and Maintain"
	And navigate to "Hire Applicants"
	And navigate to "Enter Employees"
	And navigate to "Maintain Employees"
	And navigate to "Address"
	And navigate to "Assignment"
	And navigate to "Assignment Extra Information"
	And navigate to "Basic Benefits"
	And navigate to "Competence Profile"
	And navigate to "Contact"
	And navigate to "Employee Review"
	And navigate to "End Application"
	And navigate to "End Employment"	
	And navigate to "Entries"
	And navigate to "Pay Method"	
	And navigate to "Person Extra Information"
	And navigate to "Person Type Usage"	 
	And navigate to "Phones"
	And navigate to "Qualifications"
	And navigate to "Salary Review"
	And click "Salary Admin" option
	And navigate to "Salary History"
	And navigate to "Special Information"   
	And navigate to "Supplementary Roles"
	And navigate to "Previous Employment"
	And navigate to "School/College Attendance"
	And navigate to "Contact"
	And navigate to "Requisition and Vacancy"	 
	And navigate to "Recruitment Activity"
	And navigate to "Applicant Quick Entry"
	And navigate to "Mass Update of Applicants"
	And navigate to "Schools & Colleges"
	And navigate to "Vacancies"	
	And navigate to "Grade Comparatio"
	And navigate to "Employee Benefits"
	And navigate to "Employee Assignment" 
	And navigate to "Absence"
	And navigate to "Salary"
	And click on Entries
	And navigate to "People Folder"
	And navigate to "Assignment Folder"	 
	And navigate to "People by Assignment"
	And navigate to "Assignments"   
	And navigate to "Employees by Organization"
	And navigate to "Employees by Element"
	And navigate to "Employees by Absence Type"
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"   
	And navigate to "View Requests"
	And navigate to "View Reports"
	And navigate to "Batch Element Entry"
	And navigate to "BEE Summary"

	@Oracle
Scenario: Abt US HR Executive
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HR Executive" option
	And click "Discoverer Viewer" option
	And navigate to "Enter and Maintain"
	And navigate to "Salary Management"
	And navigate to "Address"
	And navigate to "Assignment"
	And navigate to "Assignment Extra Information"
	And navigate to "Basic Benefits"
	And navigate to "Competence Profile"
	And navigate to "Contact"
	And navigate to "Employee Review"
	And navigate to "End Application"
	And navigate to "End Employment"	
	And navigate to "Entries"
	And navigate to "Pay Method"	
	And navigate to "Person Extra Information"
	And navigate to "Person Type Usage"	 
	And navigate to "Phones"
	And navigate to "Qualifications"
	And click "Salary" option
	And navigate to "Salary History"
	And navigate to "Special Information"   
	And navigate to "Supplementary Roles"
	And navigate to "Previous Employment"
	And navigate to "School/College Attendance"
	And navigate to "Contact"
	And navigate to "Requisition and Vacancy"	 
	And navigate to "Recruitment Activity"	
	And navigate to "Request Recruitment Letter"
	And navigate to "Rating Scales"
	And navigate to "Competencies" 
	And navigate to "Competence Types"
	And navigate to "Competence Requirements"
	And navigate to "Schools & Colleges"
	And navigate to "Qualification Types"
	And navigate to "Assessment Template"	 
	And navigate to "Appraisal Template"
	And click "Upload Third Party Skills" option
	And click "Objectives Library" option
	And click "Performance Management Plans" option
	And navigate to "Location" 
	And navigate to "Description"
	And click on Description Job
	And navigate to "Career Path Names"   
	And navigate to "Career Path"
	And navigate to "Job Group"
	And navigate to "Grade Rate"
	And navigate to "Element Description"
	And navigate to "Salary Basis"
	And navigate to "Salary Survey"
	And navigate to "Benefit Contributions"   
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Accruals"
	And navigate to "Employee Benefits"
	And navigate to "Worker Assignment"   
	And navigate to "Absence"
	And click on Salary
	And click on Entries
	And navigate to "People Folder"
	And navigate to "Assignment Folder"   
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Employees by Organization"
	And navigate to "Employees by Position"
	And navigate to "Emps by Position Hierarchy"   
	And navigate to "Employees by Element"
	And navigate to "Employees by Absence Type"
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"
	And navigate to "View Requests"   
	And navigate to "View Reports"
	And click "Workflow Notifications" option
	

	@Oracle
Scenario: Abt US HR Manager
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HR Manager" option
	And click "Discoverer Viewer" option
	And navigate to "Enter and Maintain"
	And navigate to "Salary Management"
	And navigate to "Address"
	And navigate to "Assignment"
	And navigate to "Assignment Extra Information"
	And navigate to "Basic Benefits"
	And navigate to "Competence Profile"
	And navigate to "Contact"
	And navigate to "Employee Review"
	And navigate to "End Application"
	And navigate to "End Employment"	
	And navigate to "Entries"
	And navigate to "Pay Method"	
	And navigate to "Person Extra Information"
	And navigate to "Person Type Usage"	 
	And navigate to "Phones"
	And navigate to "Qualifications"
	And click "Salary" option
	And navigate to "Salary History"
	And navigate to "Special Information"   
	And navigate to "Supplementary Roles"
	And navigate to "Previous Employment"
	And navigate to "School/College Attendance"
	And navigate to "Contact"
	And navigate to "Requisition and Vacancy"	 
	And navigate to "Recruitment Activity"	
	And navigate to "Request Recruitment Letter"
	And navigate to "Rating Scales"
	And navigate to "Competencies" 
	And navigate to "Competence Types"
	And navigate to "Competence Requirements"
	And navigate to "Schools & Colleges"
	And navigate to "Qualification Types"
	And navigate to "Assessment Template"	 
	And navigate to "Appraisal Template"
	And click "Upload Third Party Skills" option
	And click "Objectives Library" option
	And click "Performance Management Plans" option
	And navigate to "Location" 
	And navigate to "Description"
	And click on Description Job
	And navigate to "Career Path Names"   
	And navigate to "Career Path"
	And navigate to "Job Group"
	And navigate to "Grade Rate"
	And navigate to "Element Description"
	And navigate to "Salary Basis"
	And navigate to "Salary Survey"
	And navigate to "Benefit Contributions"   
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Accruals"
	And navigate to "Employee Benefits"
	And navigate to "Worker Assignment"   
	And navigate to "Absence"
	And click on Salary
	And click on Entries
	And navigate to "People Folder"
	And navigate to "Assignment Folder"   
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Employees by Organization"
	And navigate to "Employees by Position"
	And navigate to "Emps by Position Hierarchy"   
	And navigate to "Employees by Element"
	And navigate to "Employees by Absence Type"
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"
	And navigate to "View Requests"   
	And navigate to "View Reports"
	And click "Workflow Notifications" option  
	

	@Oracle
Scenario: US Super HRMS Manager: People
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US Super HRMS Manager" option	
	And navigate to "Enter and Maintain"
	And navigate to "Salary Management"
	And navigate to "Benefits Service Center"
	And navigate to "Reimbursement Requests"
	And navigate to "Events and Bookings"
	And navigate to "Delete Personal Records"
	And navigate to "Manage Contracts"
	And click "Search Documents of Record" option
	And navigate to "Hire Applicants"
	And navigate to "Enter Employees"
	And navigate to "Maintain Employees"
	And navigate to "Maintain Visa"	
	And navigate to "Enter Contingent Workers"
	And navigate to "Maintain Contingent Workers"	
	And navigate to "View Participation Information"
	And navigate to "Person Benefits Balances"	 
	And navigate to "Participation Overrides"
	And navigate to "What-if Eligibility"
	And navigate to "Person Benefits Assignment"
	And navigate to "COBRA Beneficiaries"   
	And navigate to "View Enrollment Results"
	And navigate to "Flex Program"
	And navigate to "Non-flex Program"
	And navigate to "Savings Plan"
	And navigate to "Miscellaneous Plan"	 
	And navigate to "Enrollment Override"	
	And navigate to "Dependent/Beneficiary Designation"
	And navigate to "Person Primary Care Provider"
	And navigate to "Court Orders" 
	And navigate to "Person Life Events"
	And navigate to "Person Enrollment Action Items"
	And navigate to "Person Enrollment Certifications"
	And navigate to "Person Communications"
	And navigate to "Record Continuing Benefits Payment"	 
	And navigate to "Monthly Participant Premium"
	And navigate to "Monthly Premiums" 
	And navigate to "Manual Payments"
	And navigate to "Mass Update of Applicant Assignments"   
	And navigate to "Mass Update of Employee Assignments"
	And click "Enter and Maintain Student Employee" option
	And click "Comparison Report" option

	@Oracle
Scenario: US Super HRMS Manager: Fast Path
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US Super HRMS Manager" option
	And navigate to "Absence"
	And navigate to "Accruals"
	And navigate to "Address"
	And navigate to "Adjust Balances"
	And navigate to "Application"
	And navigate to "Assignment"   
	And navigate to "Assignment Budget"
	And navigate to "Assignment Extra Information"
	And navigate to "Basic Benefits"
	And navigate to "Competencies"
	And navigate to "Contact"   
	And navigate to "Contracts"
	And navigate to "Employee Balances"
	And navigate to "Employee Review"   
	And navigate to "End Application"
	And navigate to "End Employment"
	And navigate to "Entries"
	And navigate to "End Placement"
	And navigate to "External/Manual Payments"   
	And navigate to "Grade Step"
	And navigate to "Pay Method"
	And navigate to "Person Extra Information"
	And navigate to "Person Type Usage"
	And navigate to "Communication Delivery Methods"   
	And navigate to "Phones"  
	And click "Picture" option
	And navigate to "Qualification Types"   
	And navigate to "QuickPay"
	And navigate to "Reverse Payroll Run"
	And navigate to "Salary History"
	And navigate to "Special Information"
	And navigate to "Tax Balances"   
	And navigate to "Tax Balance Summary"
	And navigate to "US Statement of Earnings"
	And navigate to "US Tax Information"
	And navigate to "US/CA Address"
	And navigate to "Medical Assessments"   
	And navigate to "Checklists" 
	And navigate to "Supplementary Roles"
	And navigate to "Previous Employment"   
	And navigate to "School/College Attendance"
	And navigate to "Work Incidents/OSHA"
	And navigate to "Assignment Rates"
	And click "Documents of Record" option
	And click "Absence Cases" option   
	And click "Allocate Vehicle" option
	And click "Salary" option
	And navigate to "Costing"
	And navigate to "Event"
	And navigate to "Secondary Status"   
	And navigate to "Contact" 


	@Oracle
Scenario: US Super HRMS Manager: Recruitment and Career Management
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US Super HRMS Manager" option
	And navigate to "Requisition and Vacancy"
	And navigate to "Recruitment Activity"   
	And navigate to "Applicant Quick Entry"
	And navigate to "Mass Update of Applicants"
	And navigate to "Request Recruitment Letter"
	And navigate to "Rating Scales"
	And navigate to "Competencies"   
	And navigate to "Competence Types"
	And navigate to "Competence Requirements"
	And navigate to "Schools & Colleges"
	And navigate to "Qualification Types"
	And navigate to "Assessment Template"   
	And navigate to "Appraisal Template" 
	And click "Upload Third Party Skills" option
	And click "Objectives Library" option   
	And click "Performance Management Plans" option


	@Oracle
Scenario: US Super HRMS Manager: Work Structures
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US Super HRMS Manager" option
	And navigate to "Location"
	And click "Generic Hierarchy" option
	And navigate to "Status"   
	And navigate to "Recruitment Letter Type"
	And navigate to "Contract Letter Type"
	And navigate to "Elections"
	And navigate to "Collective Agreements"
	And navigate to "Collective Agreement Grades"  
	And click on Description Organization
	And navigate to "Organization Manager"
	And navigate to "Hierarchy"
	And navigate to "Global Hierarchy"
	And click "Hr Org Operating Unit Upload" option
	And navigate to "Diagrammer"  
	And click on Description Job 
	And navigate to "Career Path Names" 
	And navigate to "Career Path"
	And navigate to "Workers Compensation Rates"
	And navigate to "Workers Compensation Codes"
	And navigate to "Job Group"
	And click on Description Position 
	And navigate to "Hierarchy"   
	And navigate to "Mass Move"
	And navigate to "Diagrammer"
	And navigate to "Position Transaction"
	And navigate to "Position Copy"
	And navigate to "Mass Position Update"   
	And click on Description Grade 
	And navigate to "Grade Rate" 
	And navigate to "Pay Scale"
	And navigate to "Point Values"   
	And navigate to "Grade Steps and Points"
	And click "Progression Approval" option
	And navigate to "Assignment Rate Types"
	And navigate to "Budget Worksheet"
	And navigate to "Budget Details"   
	And click "Budget Reallocation" option
	And navigate to "Budget Calendar"
	And navigate to "Budget Set"
	And navigate to "Budget Characteristics"
	And click "Budget Migration" option    
	And navigate to "Define Entitlement Item" 
	And navigate to "Define Collective Agreements"
	And navigate to "Define Collective Agreement Grades"
	And navigate to "Define Eligibility Profiles"
	And navigate to "Define Derived Factors"
	And click "Shifts" option  
	And click "Schedule Patterns" option
	And click "Schedules" option
	And click "Category" option
	And click "Shift Detail Type" option
	And click "Global Exception" option  
	And click "Manage Eligibility Profiles" option
	And click "Enter and Maintain Events" option
	And click "Review Calendar Event Coverage" option  
	And click "Review Applicable Events" option
	And navigate to "Eligibility Profiles"
	And click "Setup/Maintain Checklists" option


	@Oracle
Scenario: US Super HRMS Manager: Payroll
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US Super HRMS Manager" option
	And click on Description Payroll
	And navigate to "Consolidation"  	 
	And navigate to "Payment Methods"
	And navigate to "GL Flexfield Map"
	And navigate to "Update Payroll Run"
	And navigate to "Assignment Set"
	And navigate to "Element Set"   
	And navigate to "RetroPay Set" 
	And navigate to "GL Daily Rates"
	And navigate to "Conversion Rate Types"
	And navigate to "Monetary Units"
	And navigate to "Balance Set"


	@Oracle
Scenario: US Super HRMS Manager: Total Compensation
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US Super HRMS Manager" option
	And click "Total Compensation Setup Wizard" option  
	And navigate to "Deductions"
	And navigate to "Element Description"
	And navigate to "Link"
	And navigate to "Tax Withholding Rules"
	And navigate to "Salary Basis"   
	And navigate to "Compensation Survey" 
	And navigate to "Benefit Contributions"
	And navigate to "Absence Types"
	And navigate to "Accrual Plans"
	And navigate to "Balance"
	And navigate to "Classification"   
	And click "Vehicle Repository" option 
	And click "Fast Formula Assistant" option 
	And navigate to "Write Formula"
	And navigate to "Formula Results"
	And navigate to "Global Values"
	And navigate to "Formula Functions"
	And navigate to "Message Configuration"   
	And navigate to "Authentication Activities" 
	And navigate to "Benefits Group"
	And navigate to "Benefit Balances"
	And navigate to "Derived Factors"
	And navigate to "Postal/Zip"
	And navigate to "Service Areas"   
	And navigate to "Participant" 
	And navigate to "Dependent Coverage"
	And click "Maintain Eligibility Criteria Type" option
	And navigate to "Program/Plan Years"
	And navigate to "Regulations"
	And navigate to "Reporting Groups"   
	And navigate to "Goods and Services" 
	And navigate to "Life Event Reasons"
	And navigate to "Collapse Life Events"
	And navigate to "Communication Types"
	And navigate to "Enrollment Action Types"
	And navigate to "View Program Structure"   
	And navigate to "Plan Types" 
	And navigate to "Options"
	And navigate to "Plans"
	And navigate to "Plan Enrollment Requirements"
	And navigate to "Plan Reimbursements"
	And navigate to "Plan Primary Care Providers"   
	And navigate to "Programs" 
	And navigate to "Program Enrollment Requirements"
	And click "Plan Design Copy" option
	And navigate to "Plan Third Party Identifier"
	And navigate to "Variable Rate Profiles"
	And navigate to "Standard Rates"   
	And navigate to "Period-to-Date Limits" 
	And navigate to "Coverage Calculations"
	And navigate to "Coverage Across Plan Types"
	And navigate to "Actual Premiums"
	And navigate to "Imputed Income"
	And navigate to "Benefits Pools"   
	And navigate to "Flex Credits" 
	And navigate to "Combinations"
	And click "Maintain Criteria Rate Definition" option
	And click "Maintain Rate Matrix" option
	And navigate to "Earnings Rules"
	And navigate to "Exemption Rules"   
	And navigate to "Fee Rules" 
	And navigate to "Limit Rules" 


	@Oracle
Scenario: US Super HRMS Manager: View
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US Super HRMS Manager" option
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Benefits"
	And navigate to "Employee Accruals"
	And navigate to "Employee Balances"   
	And navigate to "Tax Balances" 
	And navigate to "Payroll Process Results"
	And navigate to "Assignment Process Results"
	And navigate to "System Messages"
	And click "Retropay Status" option
	And navigate to "Worker Assignment"   
	And navigate to "Absence" 
	And navigate to "Run Results"
	And click on SalaryB 
	And navigate to "Entries"
	And navigate to "Contribution History (Def Comp 457)"
	And navigate to "People Folder"   
	And navigate to "Assignment Folder" 
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Workforce by Organization"
	And navigate to "Workforce by Position"
	And navigate to "Workforce by Position Hierarchy"   
	And navigate to "Employees by Element" 
	And navigate to "Employees by Absence Type" 
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"
	And navigate to "View Requests"
	And navigate to "View Reports"
	And click "Workflow Notifications" option   
	And navigate to "Batch Process Parameters" 
	And navigate to "Monitor Batch Processes"
	And navigate to "Define a Quickpaint Report"
	And navigate to "Run a Quickpaint Report"
	And navigate to "Submit Custom Reports"
	And navigate to "Maintain Process Parameters"   
	And navigate to "Process Log" 
	And navigate to "Roles"
	And navigate to "Routing Lists"
	And click "Configurable Business Rules" option
	And navigate to "Templates"
	And navigate to "Transaction Type Wizard"   
	And navigate to "Global Roles" 
	And click "Document Management" option
	And navigate to "Transaction Categories"


	@Oracle
Scenario: US Super HRMS Manager: Mass Information Definitiions and Security
    Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US Super HRMS Manager" option
	And navigate to "Batch Element Entry"
	And navigate to "BEE Summary"
	And click "BEE Spreadsheet Interface" option   
	And click "BBA Spreadsheet Interface" option 
	And navigate to "Layout Definition" 
	And navigate to "Criteria Definition"
	And navigate to "Extract Definition"
	And navigate to "Extract Results"
	And navigate to "Change Event Log"
	And navigate to "Person Types"   
	And navigate to "Lookup Tables" 
	And navigate to "Special Information Types"
	And navigate to "Table Structure"
	And navigate to "Table Values"
	And navigate to "US Cities"
	And navigate to "Time Periods"   
	And navigate to "User Profile Options" 
	And navigate to "User Types and Statuses"
	And navigate to "Dynamic Triggers"
	And navigate to "Functional Areas"
	And navigate to "Define Event Group"
	And navigate to "Table Event Updates" 	  
	And click "Configuration Values" option 
	And click "Person Name Formats" option
	And click "Dynamic Time Periods" option
	And click "Reports" option
	And click "Groups" option
	And click "Concurrent Request Monitoring/Viewing" option  
	And navigate to "Profile" 
	And navigate to "Global Profile" 
	And navigate to "Information Types Security"
	And navigate to "CustomForm"
	And navigate to "Report Sets"
	And navigate to "Task Flow Nodes"
	And navigate to "Task Flow Definitions"   
	And navigate to "People Management Configurator" 
	And navigate to "Contexts"
	And navigate to "Transaction Status"
	And navigate to "Task Flow Unit"
	And navigate to "Assign Security Profiles"	


	@Oracle
	Scenario: US HRMS Manager: People
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HRMS Manager" option	
	And navigate to "Shared"
	And navigate to "Enter and Maintain"
	And navigate to "Salary Management"
	And navigate to "Events and Bookings"
	And navigate to "Delete Personal Records"
	And navigate to "Manage Contracts"
	And click "Search Documents of Record" option
	And navigate to "Hiring Applicants"
	And navigate to "Entering Employees"
	And navigate to "Maintaining Employees"
	And navigate to "Maintaining Visa"	
	And navigate to "Entering Contingent Workers"
	And navigate to "Maintaining Contingent Workers"		
	And navigate to "Person Benefits Balances"
	And navigate to "Person Benefits Assignments"
	And navigate to "COBRA Beneficiaries"  		 
	And navigate to "Participation Overrides" 
	And navigate to "View Enrollment Results"
	And navigate to "Non-flex Program"
	And navigate to "Savings Plan"
	And navigate to "Miscellaneous Plan"	 
	And navigate to "Enrollment Override"	
	And navigate to "Dependent/Beneficiary Designation"
	And navigate to "Person Primary Care Provider"
	And navigate to "Court Orders" 
	And navigate to "Person Communications"
	And navigate to "Person Life Events"
	And navigate to "Record Continuing Benefits Payment"	 
	And navigate to "Monthly Participant Premium"
	And navigate to "Monthly Premiums" 
	And navigate to "Manual Payments"
	And navigate to "Mass Update of Applicant Assignments"   
	And navigate to "Mass Update of Employee Assignments"
	And click "Enter and Maintain Student Employee" option
	And click "Comparison Report" option


	@Oracle
Scenario: US HRMS Manager: Fast Path
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HRMS Manager" option	
	And navigate to "Absence"
	And navigate to "Accruals"
	And navigate to "Address"
	And navigate to "Adjust Balances"
	And navigate to "Application"
	And navigate to "Assignment"   
	And navigate to "Assignment Budget"
	And navigate to "Assignment Extra Information"
	And navigate to "Basic Benefits"
	And navigate to "Competence Profile"
	And navigate to "Contact"   
	And navigate to "Contracts"
	And navigate to "Employee Balances"
	And navigate to "Employee Review"   
	And navigate to "End Application"
	And navigate to "End Employment"
	And navigate to "Entries"
	And navigate to "End Placement"
	And navigate to "External/Manual Payments"   
	And navigate to "Grade Step"
	And navigate to "Pay Method"
	And navigate to "Person Extra Information"
	And navigate to "Person Type Usage"
	And navigate to "Communication Delivery Methods"   
	And navigate to "Phones"  
	And click "Picture" option
	And navigate to "Qualifications"   
	And navigate to "QuickPay"
	And navigate to "Reverse Payroll Run"
	And navigate to "Salary History"
	And navigate to "Salary Review"
	And navigate to "Special Information"
	And navigate to "Tax Balances" 
	And navigate to "Statement of Earnings"  
	And navigate to "US Tax Information"
	And navigate to "Adjust Tax Balances"
	And navigate to "US/CA Address"
	And navigate to "Tax Balance Summary"
	And navigate to "Medical Assessments"   
	And navigate to "Checklists" 
	And navigate to "Supplementary Roles"
	And navigate to "Previous Employment"   
	And navigate to "School/College Attendance"
	And navigate to "Assignment Rates"
	And click "Documents of Record" option
	And click "Allocate Vehicle" option
	And click "Salary" option
	And navigate to "Contact"
	And navigate to "Costing"
	And navigate to "Event"
	And navigate to "Secondary Status" 
	 
	 @Oracle
Scenario: US HRMS Manager: Recruitment and Career Management
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HRMS Manager" option	 
	And navigate to "Requisition and Vacancy"
	And navigate to "Recruitment Activity"   
	And navigate to "Applicant Quick Entry"
	And navigate to "Mass Update of Applicants"
	And navigate to "Request Recruitment Letter"
	And navigate to "Rating Scales"
	And navigate to "Competencies"   
	And navigate to "Competence Types"
	And navigate to "Competence Requirements"
	And navigate to "Schools & Colleges"
	And navigate to "Qualification Types"
	And navigate to "Assessment Template"   
	And navigate to "Appraisal Template" 
	And click "Upload Third Party Skills" option
	And click "Objectives Library" option   
	And click "Performance Management Plans" option


	@Oracle
Scenario: US HRMS Manager: Work Structures
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HRMS Manager" option	
	And navigate to "Location"
	And click "Generic Hierarchy" option
	And navigate to "Status"   
	And navigate to "Recruitment Letter Type"
	And navigate to "Contract Letter Type"
	And navigate to "Elections"
	And navigate to "Assignment Rate Types"
	And navigate to "Collective Agreements and Grade Structures"
	And navigate to "Collective Agreements" 
	And navigate to "Define Entitlement Item" 
	And navigate to "Define Eligibility Profiles"
	And navigate to "Define Collective Agreement"
	And navigate to "Define Collective Agreement Grades"
	And navigate to "Define Derived Factors" 
	And click on Description Organization
	And navigate to "Organization Manager"
	And navigate to "Hierarchy"
	And navigate to "Diagrammer"
	And navigate to "Global Hierarchy"
	And click "Hr Org Operating Unit Upload" option  
	And click on Description Job 
	And navigate to "Career Path Names" 
	And navigate to "Career Path"
	And navigate to "Workers Compensation Rates"
	And navigate to "Workers Compensation Codes"
	And navigate to "Job Group"
	And click on Description Position 
	And navigate to "Hierarchy"   
	And navigate to "Mass Move"
	And navigate to "Diagrammer"
	And navigate to "Position Transaction"
	And navigate to "Position Copy"
	And navigate to "Mass Position Update"   
	And click on Description Grade 
	And navigate to "Grade Rate" 
	And navigate to "Pay Scale"
	And navigate to "Point Values"   
	And navigate to "Grade Steps and Points"
	And click "Progression Approval" option
	And navigate to "Budget Worksheet"
	And navigate to "Budget Details"   
	And click "Budget Reallocation" option
	And navigate to "Budget Calendar"
	And navigate to "Budget Set"
	And navigate to "Budget Characteristics"
	And click "Budget Migration" option    
	And click "Shifts" option  
	And click "Schedule Patterns" option
	And click "Schedules" option
	And click "Category" option
	And click "Shift Detail Type" option
	And click "Global Exception" option  
	And click "Manage Eligibility Profiles" option
	And click "Enter and Maintain Events" option
	And click "Review Calendar Event Coverage" option  
	And click "Review Applicable Events" option
	And navigate to "Eligibility Profiles"
	And click "Setup/Maintain Checklists" option

	@Oracle
Scenario: US HRMS Manager: Payroll
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HRMS Manager" option	
	And click on Description Payroll
	And navigate to "Consolidation"  	 
	And navigate to "Payment Methods"
	And navigate to "GL Flexfield Map"
	And navigate to "Update Payroll Run"
	And navigate to "Assignment Set"
	And navigate to "Element Set"   
	And navigate to "RetroPay Set" 
	And navigate to "GL Daily Rates"
	And navigate to "Conversion Rate Types"
	And navigate to "Monetary Units"
	And navigate to "Balance Set"


	@Oracle
Scenario: US HRMS Manager: Total Compensation
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HRMS Manager" option	
	And click "Total Compensation Setup Wizard" option  
	And navigate to "Element Description"
	And navigate to "Link"
	And navigate to "Earnings"
	And navigate to "Tax Withholding Rules"
	And navigate to "Salary Basis"   
	And navigate to "Compensation Survey" 
	And navigate to "Deductions"
	And navigate to "Benefit Contributions"
	And navigate to "Absence Types"
	And navigate to "Accrual Plans"
	And navigate to "Balance"
	And navigate to "Classification"   
	And click "Vehicle Repository" option 
	And click "Fast Formula Assistant" option 
	And navigate to "Write Formula"
	And navigate to "Formula Results"
	And navigate to "Global Values"
	And navigate to "Formula Functions"
	And navigate to "Benefits Group"
	And navigate to "Benefit Balances"
	And navigate to "Derived Factors"
	And navigate to "Postal/Zip"
	And navigate to "Service Areas"   
	And navigate to "Participant" 
	And navigate to "Dependent Coverage"
	And click "Maintain Eligibility Criteria" option
	And navigate to "Program/Plan Years"
	And navigate to "Regulations"
	And navigate to "Reporting Groups"   
	And navigate to "Goods and Services"
	And navigate to "Communication Types" 
	And navigate to "Life Event Reasons"
	And navigate to "View Program Structure"   
	And navigate to "Plan Types" 
	And navigate to "Options"
	And navigate to "Plans"
	And navigate to "Plan Enrollment Requirements"
	And navigate to "Plan Primary Care Providers"   
	And navigate to "Programs" 
	And navigate to "Program Enrollment Requirements"
	And click "Plan Design Copy" option
	And navigate to "Plan Third Party Identifier"
	And navigate to "Variable Rate Profiles"
	And navigate to "Standard Rates"   
	And navigate to "Period-to-date Limits" 
	And navigate to "Coverage Calculations"
	And navigate to "Coverage Across Plan Types"
	And navigate to "Actual Premiums"
	And navigate to "Imputed Income"
	And click "Maintain Criteria Rate Definition" option
	And click "Maintain Rate Matrix" option
	And navigate to "Earnings Rules"
	And navigate to "Exemption Rules"   
	And navigate to "Fee Rules" 
	And navigate to "Limit Rules"
	

	@Oracle
Scenario: US HRMS Manager: View
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HRMS Manager" option	 
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Accruals"
	And navigate to "Employee Balances"   
	And navigate to "Tax Balances" 
	And navigate to "Payroll Process Results"
	And navigate to "Assignment Process Results"
	And navigate to "System Messages"
	And click "Retropay Status" option
	And navigate to "Worker Assignment"   
	And navigate to "Absence" 
	And navigate to "Run Results"
	And click on SalaryB
	And navigate to "Entries"
	And navigate to "Contribution History (Def Comp 457)"
	And navigate to "People Folder"   
	And navigate to "Assignment Folder" 
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Workforce by Organization"
	And navigate to "Workforce by Position"
	And navigate to "Workforce by Position Hierarchy"   
	And navigate to "Employees by Element" 
	And navigate to "Employees by Absence Type" 
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"
	And navigate to "View Requests"
	And navigate to "View Reports"
	And click "Workflow Notifications" option   
	And navigate to "Batch Process Parameters" 
	And navigate to "Monitor Batch Processes"
	And navigate to "Define a Quickpaint Report"
	And navigate to "Run a Quickpaint Report"
	And navigate to "Submit Custom Reports"  
	And navigate to "Process Log" 
	And navigate to "Roles"
	And navigate to "Routing Lists"
	And click "Configurable Business Rules" option
	And navigate to "Templates"
	And navigate to "Transaction Type Wizard"   
	And navigate to "Global Roles" 
	And click "Document Management" option
	And navigate to "Transaction Categories"


	@Oracle
Scenario: US HRMS Manager: Mass Information Definitions and Security
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HRMS Manager" option	
	And navigate to "Batch Element Entry"
	And navigate to "BEE Summary"
	And click "BEE Spreadsheet Interface" option   
	And click "BBA Spreadsheet Interface" option 
	And navigate to "Layout Definition" 
	And navigate to "Criteria Definition"
	And navigate to "Extract Definition"
	And navigate to "Extract Results"
	And navigate to "Change Event Log"
	And navigate to "Person Types"   
	And navigate to "Application Utilities Lookups" 
	And navigate to "Special Information Types"
	And navigate to "Define Cities"
	And navigate to "Table Structure"
	And navigate to "Table Values"
	And navigate to "Time Periods"   
	And navigate to "User Profile Options" 
	And navigate to "User Types and Statuses"
	And navigate to "Dynamic Triggers"
	And navigate to "Functional Areas"
	And navigate to "Define Event Group"	  
	And click "Configuration Values" option 
	And click "Person Name Formats" option
	And click "Dynamic Time Periods" option
	And click "Reports" option
	And click "Groups" option
	And click "Concurrent Request Monitoring/Viewing" option  
	And navigate to "Profile" 
	And navigate to "Assign Security Profiles"
	And navigate to "CustomForm"
	And navigate to "Information Types Security"
	And navigate to "Report Sets"
	And navigate to "Task Flow Nodes"
	And navigate to "Task Flow Definitions"   
	And navigate to "Forms Configurator" 
	And navigate to "Contexts"
	And navigate to "Transaction Status"
	And navigate to "Task Flow Units"
	And navigate to "Global Profile"


	@Oracle
Scenario: US HR Manager: People
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HR Manager" option
	And navigate to "Enter and Maintain"
	And navigate to "Salary Management"
	And navigate to "Events and Bookings"
	And navigate to "Delete Personal Records"
	And navigate to "Manage Contracts"
	And click "Search Documents of Record" option		
	And navigate to "Hiring Applicants"
	And navigate to "Entering Employees"
	And navigate to "Maintaining Employees"
	And navigate to "Maintaining Visa"	
	And navigate to "Entering Contingent Workers"
	And navigate to "Maintaining Contingent Workers"	
	And navigate to "Person Benefits Balances"
	And navigate to "Person Benefits Assignment"
	And navigate to "COBRA Beneficiaries"	 
	And navigate to "Participation Overrides"	   
	And navigate to "View Enrollment Results"
	And navigate to "Non-flex Program"
	And navigate to "Savings Plan"
	And navigate to "Miscellaneous Plan"	 
	And navigate to "Enrollment Override"	
	And navigate to "Dependent/Beneficiary Designation"
	And navigate to "Person Primary Care Provider"
	And navigate to "Court Orders" 
	And navigate to "Person Communications"
	And navigate to "Person Life Events"
	And navigate to "Record Continuing Benefits Payment"	 
	And navigate to "Monthly Participant Premium"
	And navigate to "Monthly Premiums" 
	And navigate to "Manual Payments"
	And navigate to "Mass Update of Applicant Assignments"   
	And navigate to "Mass Update of Employee Assignments"


	@Oracle
Scenario: US HR Manager: Fast Path Recruitment and Career Management
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HR Manager" option
	And navigate to "Absence"
	And navigate to "Accruals"
	And navigate to "Address"
	And navigate to "Application"
	And navigate to "Assignment"   
	And navigate to "Assignment Budget"
	And navigate to "Assignment Extra Information"
	And navigate to "Basic Benefits"
	And navigate to "Competence Profile"
	And navigate to "Contact"   
	And navigate to "Contracts" 
	And navigate to "End Application"
	And navigate to "End Employment"
	And navigate to "Entries"
	And navigate to "End Placement" 
	And navigate to "Grade Step"
	And navigate to "Pay Method"
	And navigate to "Person Extra Information"
	And navigate to "Person Type Usage"
	And navigate to "Communication Delivery Methods"   
	And navigate to "Phones"  
	And click "Picture" option
	And navigate to "Qualifications"   
	And navigate to "Salary History" 
	And navigate to "Special Information" 
	And navigate to "US/CA Address"
	And navigate to "Medical Assessments"
	And navigate to "Checklists" 
	And navigate to "Supplementary Roles"
	And navigate to "Previous Employment"   
	And navigate to "School/College Attendance"
	And navigate to "Assignment Rates"
	And click "Documents of Record" option
	And click "Salary" option
	And navigate to "Contact"
	And navigate to "Employee Review"
	And navigate to "Event"
	And navigate to "Secondary Status" 
	And navigate to "Requisition and Vacancy"
	And navigate to "Recruitment Activity"   
	And navigate to "Applicant Quick Entry"
	And navigate to "Mass Update of Applicants"
	And navigate to "Request Recruitment Letter"
	And navigate to "Rating Scales"
	And navigate to "Competencies"   
	And navigate to "Competence Types"
	And navigate to "Competence Requirements"
	And navigate to "Schools & Colleges"
	And navigate to "Qualification Types"
	And navigate to "Assessment Template"   
	And navigate to "Appraisal Template" 
	And click "Upload Third Party Skills" option
	And click "Objectives Library" option   
	And click "Performance Management Plans" option


	@Oracle
Scenario: US HR Manager: Work Structures 
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HR Manager" option
	And navigate to "Location"
	And click "Generic Hierarchy" option
	And navigate to "Status"   
	And navigate to "Recruitment Letter Type"
	And navigate to "Contract Letter Type"
	And navigate to "Elections"
	And navigate to "Collective Agreements and Grade Structures"
	And navigate to "Collective Agreements"
	And navigate to "Define Entitlement Item" 
	And navigate to "Define Collective Agreement"
	And navigate to "Define Collective Agreement Grades"
	And navigate to "Define Eligibility Profiles"
	And navigate to "Define Derived Factors"  
	And click on Description Organization
	And navigate to "Organization Manager"
	And navigate to "Hierarchy"
	And navigate to "Diagrammer"
	And navigate to "Global Hierarchy"
	 And navigate to "Global Security"
	And click on Description Job 
	And navigate to "Career Path Names" 
	And navigate to "Career Path"
	And navigate to "Job Group"	
	And click on Description Position 
	And navigate to "Hierarchy"   
	And navigate to "Mass Move"
	And navigate to "Diagrammer"
	And navigate to "Position Transaction"
	And navigate to "Position Copy"
	And navigate to "Mass Position Update"   
	And click on Description Grade 
	And navigate to "Grade Rate" 
	And navigate to "Pay Scale"
	And navigate to "Point Values"   
	And navigate to "Grade Steps and Points"
	And click "Progression Approval" option
	And navigate to "Assignment Rate Types"
	And navigate to "Budget Worksheet"
	And navigate to "Budget Details"   
	And click "Budget Reallocation" option
	And navigate to "Budget Calendar"
	And navigate to "Budget Set"
	And navigate to "Budget Characteristics"
	And click "Budget Migration" option    
	And click "Shifts" option  
	And click "Schedule Patterns" option
	And click "Schedules" option
	And click "Category" option
	And click "Shift Detail Type" option
	And click "Global Exception" option  
	And click "Manage Eligibility Profiles" option
	And click "Enter and Maintain Events" option
	And click "Review Calendar Event Coverage" option  
	And click "Review Applicable Events" option
	And navigate to "Eligibility Profiles"
	And click "Setup/Maintain Checklists" option


	@Oracle
Scenario: US HR Manager: Payroll and total compensation
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HR Manager" option
	And click on Description Payroll	 
	And navigate to "Payment Methods"
	And navigate to "Assignment Set"
	And navigate to "Element Set" 
	And navigate to "GL Daily Rates"
	And navigate to "Conversion Rate Types"
	And navigate to "Monetary Units"
	And click "Total Compensation Setup Wizard" option  
	And navigate to "Element Description"
	And navigate to "Link"
	And navigate to "Salary Basis"   
	And navigate to "Compensation Survey" 
	And navigate to "Benefit Contributions"
	And navigate to "Absence Types"
	And navigate to "Accrual Plans"
	And navigate to "Write Formulas"
	And navigate to "Global Values"
	And navigate to "Balance"
	And navigate to "Benefits Group"
	And navigate to "Benefit Balances"
	And navigate to "Derived Factors"
	And navigate to "Postal/Zip"
	And navigate to "Service Areas"   
	And navigate to "Participant" 
	And navigate to "Dependent Coverage"
	And click "Maintain Eligibility Criteria" option	
	And navigate to "Program/Plan Years"
	And navigate to "Regulations"
	And navigate to "Reporting Groups"   
	And navigate to "Goods and Services" 
	And navigate to "Communication Types"
	And navigate to "Life Event Reasons"
	And navigate to "View Program Structure"   
	And navigate to "Plan Types" 
	And navigate to "Options"
	And navigate to "Plans"
	And navigate to "Plan Enrollment Requirements"
	And navigate to "Plan Primary Care Providers"   
	And navigate to "Programs" 
	And navigate to "Program Enrollment Requirements"
	And click "Plan Design Copy" option
	And navigate to "Plan Third Party Identifier"
	And navigate to "Variable Rate Profiles"
	And navigate to "Standard Rates"   
	And navigate to "Period-to-date Limits" 
	And navigate to "Coverage Calculations"
	And navigate to "Coverage Across Plan Types"
	And navigate to "Actual Premiums"
	And navigate to "Imputed Income"   
	And click "Maintain Criteria Rate Definition" option
	And click "Maintain Rate Matrix" option	


	@Oracle
Scenario: US HR Manager: View to Security  
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "US HR Manager" option
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Accruals" 
	And navigate to "Employee Benefits"
	And navigate to "Worker Assignment"   
	And navigate to "Absence" 
	And click on Salary 
	And navigate to "Entries"
	And navigate to "People Folder"   
	And navigate to "Assignment Folder" 
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Workforce by Organization"
	And navigate to "Workforce by Position"
	And navigate to "Workforce by Position Hierarchy"   
	And navigate to "Employees by Element" 
	And navigate to "Employees by Absence Type" 
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"
	And navigate to "View Requests"
	And navigate to "View Reports"
	And click "Workflow Notifications" option   
	And navigate to "Batch Process Parameters" 
	And navigate to "Monitor Batch Processes"
	And navigate to "Submit Custom Reports"
	And navigate to "Process Log" 
	And navigate to "Define a QuickPaint Report"
	And navigate to "Run a QuickPaint Report"	
	And navigate to "Roles"
	And navigate to "Routing Lists"
	And click "Configurable Business Rules" option
	And navigate to "Templates"
	And navigate to "Transaction Type Wizard"   
	And navigate to "Global Roles" 
	And click "Document Management" option
	And navigate to "Transaction Categories"  
	And navigate to "Batch Element Entry"
	And navigate to "BEE Summary"
	And navigate to "Extract Definition"
	And navigate to "Layout Definition" 
	And navigate to "Criteria Definition"
	And navigate to "Extract Results"
	And navigate to "Change Event Log"
	And navigate to "Person Types"   
	And navigate to "Application Utilities Lookups" 
	And navigate to "Special Information Types"
	And navigate to "Table Structure"
	And navigate to "Table Values"
	And navigate to "Time Periods"   
	And navigate to "User Profile Options" 
	And navigate to "Formula Functions" 
	And navigate to "User Types and Statuses"
	And navigate to "Dynamic Triggers"
	And navigate to "Functional Areas"	  
	And navigate to "Third Party Payroll Balance Types"
	And navigate to "Third Party Payroll Org Run Results"
	And navigate to "Third Party Payroll Emp Run Results"
	And click "Person Name Formats" option  
	And navigate to "Profile" 
	And navigate to "Assign Security Profiles" 
	And navigate to "CustomForm"
	And navigate to "Information Types Security"
	And navigate to "Report Sets"
	And navigate to "Task Flow Nodes"
	And navigate to "Task Flow Definitions"   
	And navigate to "Forms Configurator"	
	And navigate to "Contexts"
	And navigate to "Transaction Status"
	And navigate to "Global Profile"


	@Oracle
Scenario: Abt US HR Technical Manager: People
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HR Technical Manager" option
	And navigate to "Enter and Maintain"
	And navigate to "Salary Management"
	And navigate to "Events and Bookings"
	And navigate to "Delete Personal Records"
	And navigate to "Manage Contracts"
	And click "Search Documents of Record" option		
	And navigate to "Hiring Applicants"
	And navigate to "Entering Employees"
	And navigate to "Maintaining Employees"
	And navigate to "Maintaining Visa"	
	And navigate to "Entering Contingent Workers"
	And navigate to "Maintaining Contingent Workers"	
	And navigate to "Person Benefits Balances"
	And navigate to "Person Benefits Assignment"
	And navigate to "COBRA Beneficiaries"	 
	And navigate to "Participation Overrides"	   
	And navigate to "View Enrollment Results"
	And navigate to "Non-flex Program"
	And navigate to "Savings Plan"
	And navigate to "Miscellaneous Plan"	 
	And navigate to "Enrollment Override"	
	And navigate to "Dependent/Beneficiary Designation"
	And navigate to "Person Primary Care Provider"
	And navigate to "Court Orders" 
	And navigate to "Person Communications"
	And navigate to "Person Life Events"
	And navigate to "Record Continuing Benefits Payment"	 
	And navigate to "Monthly Participant Premium"
	And navigate to "Monthly Premiums" 
	And navigate to "Manual Payments"
	And navigate to "Mass Update of Applicant Assignments"   
	And navigate to "Mass Update of Employee Assignments"


	@Oracle
Scenario: Abt US HR Technical Manager: Fast Path
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HR Technical Manager" option
	And navigate to "Absence"
	And navigate to "Accruals"
	And navigate to "Address"
	And navigate to "Application"
	And navigate to "Assignment"   
	And navigate to "Assignment Budget"
	And navigate to "Assignment Extra Information"
	And navigate to "Basic Benefits"
	And navigate to "Competence Profile"
	And navigate to "Contact"   
	And navigate to "Contracts" 
	And navigate to "End Application"
	And navigate to "End Employment"
	And navigate to "Entries"
	And navigate to "End Placement" 
	And navigate to "Grade Step"
	And navigate to "Pay Method"
	And navigate to "Person Extra Information"
	And navigate to "Person Type Usage"
	And navigate to "Communication Delivery Methods"   
	And navigate to "Phones"  
	And click "Picture" option
	And navigate to "Qualifications"   
	And navigate to "Salary History" 
	And navigate to "Special Information" 
	And navigate to "US/CA Address"
	And navigate to "Medical Assessments"
	And navigate to "Checklists" 
	And navigate to "Supplementary Roles"
	And navigate to "Previous Employment"   
	And navigate to "School/College Attendance"
	And navigate to "Assignment Rates"
	And click "Documents of Record" option
	And click "Salary" option
	And navigate to "Contact"
	And navigate to "Employee Review"
	And navigate to "Event"
	And navigate to "Secondary Status"


@Oracle	
Scenario: Abt US HR Technical Manager: Recruitment and Career Management
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HR Technical Manager" option
    And navigate to "Requisition and Vacancy"
	And navigate to "Recruitment Activity"   
	And navigate to "Applicant Quick Entry"
	And navigate to "Mass Update of Applicants"
	And navigate to "Request Recruitment Letter"
	And navigate to "Rating Scales"
	And navigate to "Competencies"   
	And navigate to "Competence Types"
	And navigate to "Competence Requirements"
	And navigate to "Schools & Colleges"
	And navigate to "Qualification Types"
	And navigate to "Assessment Template"   
	And navigate to "Appraisal Template" 
	And click "Upload Third Party Skills" option
	And click "Objectives Library" option   
	And click "Performance Management Plans" option 


	@Oracle
Scenario: Abt US HR Technical Manager: Work Structures
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HR Technical Manager" option
	And navigate to "Location"
	And click "Generic Hierarchy" option
	And navigate to "Status"   
	And navigate to "Recruitment Letter Type"
	And navigate to "Contract Letter Type"
	And navigate to "Elections"
	And navigate to "Collective Agreements and Grade Structures"
	And navigate to "Collective Agreements"
	And navigate to "Define Entitlement Item" 
	And navigate to "Define Collective Agreement"
	And navigate to "Define Collective Agreement Grades"
	And navigate to "Define Eligibility Profiles"
	And navigate to "Define Derived Factors"  
	And click on Description Organization
	And navigate to "Organization Manager"
	And navigate to "Hierarchy"
	And navigate to "Diagrammer"
	And navigate to "Global Hierarchy"
	 And navigate to "Global Security"
	And click on Description Job 
	And navigate to "Career Path Names" 
	And navigate to "Career Path"
	And navigate to "Job Group"	
	And click on Description Position 
	And navigate to "Hierarchy"   
	And navigate to "Mass Move"
	And navigate to "Diagrammer"
	And navigate to "Position Transaction"
	And navigate to "Position Copy"
	And navigate to "Mass Position Update"   
	And click on Description Grade 
	And navigate to "Grade Rate" 
	And navigate to "Pay Scale"
	And navigate to "Point Values"   
	And navigate to "Grade Steps and Points"
	And click "Progression Approval" option
	And navigate to "Assignment Rate Types"
	And navigate to "Budget Worksheet"
	And navigate to "Budget Details"   
	And click "Budget Reallocation" option
	And navigate to "Budget Calendar"
	And navigate to "Budget Set"
	And navigate to "Budget Characteristics"
	And click "Budget Migration" option    
	And click "Shifts" option  
	And click "Schedule Patterns" option
	And click "Schedules" option
	And click "Category" option
	And click "Shift Detail Type" option
	And click "Global Exception" option  
	And click "Manage Eligibility Profiles" option
	And click "Enter and Maintain Events" option
	And click "Review Calendar Event Coverage" option  
	And click "Review Applicable Events" option
	And navigate to "Eligibility Profiles"
	And click "Setup/Maintain Checklists" option


	@Oracle
Scenario: Abt US HR Technical Manager: Payroll and Total Compensation
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HR Technical Manager" option
	And click on Description Payroll	 
	And navigate to "Payment Methods"
	And navigate to "Assignment Set"
	And navigate to "Element Set" 
	And navigate to "GL Daily Rates"
	And navigate to "Conversion Rate Types"
	And navigate to "Monetary Units"
	And click "Total Compensation Setup Wizard" option  
	And navigate to "Element Description"
	And navigate to "Link"
	And navigate to "Salary Basis"   
	And navigate to "Compensation Survey" 
	And navigate to "Benefit Contributions"
	And navigate to "Absence Types"
	And navigate to "Accrual Plans"
	And navigate to "Write Formulas"
	And navigate to "Global Values"
	And navigate to "Balance"
	And navigate to "Benefits Group"
	And navigate to "Benefit Balances"
	And navigate to "Derived Factors"
	And navigate to "Postal/Zip"
	And navigate to "Service Areas"   
	And navigate to "Participant" 
	And navigate to "Dependent Coverage"
	And click "Maintain Eligibility Criteria" option	
	And navigate to "Program/Plan Years"
	And navigate to "Regulations"
	And navigate to "Reporting Groups"   
	And navigate to "Goods and Services" 
	And navigate to "Communication Types"
	And navigate to "Life Event Reasons"
	And navigate to "View Program Structure"   
	And navigate to "Plan Types" 
	And navigate to "Options"
	And navigate to "Plans"
	And navigate to "Plan Enrollment Requirements"
	And navigate to "Plan Primary Care Providers"   
	And navigate to "Programs" 
	And navigate to "Program Enrollment Requirements"
	And click "Plan Design Copy" option
	And navigate to "Plan Third Party Identifier"
	And navigate to "Variable Rate Profiles"
	And navigate to "Standard Rates"   
	And navigate to "Period-to-date Limits" 
	And navigate to "Coverage Calculations"
	And navigate to "Coverage Across Plan Types"
	And navigate to "Actual Premiums"
	And navigate to "Imputed Income"   
	And click "Maintain Criteria Rate Definition" option
	And click "Maintain Rate Matrix" option	


	@Oracle
Scenario: Abt US HR Technical Manager: View to Security  
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HR Technical Manager" option
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Accruals" 
	And navigate to "Employee Benefits"
	And navigate to "Worker Assignment"   
	And navigate to "Absence" 
	And click on Salary 
	And navigate to "Entries"
	And navigate to "People Folder"   
	And navigate to "Assignment Folder" 
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Workforce by Organization"
	And navigate to "Workforce by Position"
	And navigate to "Workforce by Position Hierarchy"   
	And navigate to "Employees by Element" 
	And navigate to "Employees by Absence Type" 
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"
	And navigate to "View Requests"
	And navigate to "View Reports"
	And click "Workflow Notifications" option   
	And navigate to "Batch Process Parameters" 
	And navigate to "Monitor Batch Processes"
	And navigate to "Submit Custom Reports"
	And navigate to "Process Log" 
	And navigate to "Define a QuickPaint Report"
	And navigate to "Run a QuickPaint Report"	
	And navigate to "Roles"
	And navigate to "Routing Lists"
	And click "Configurable Business Rules" option
	And navigate to "Templates"
	And navigate to "Transaction Type Wizard"   
	And navigate to "Global Roles" 
	And click "Document Management" option
	And navigate to "Transaction Categories"  
	And navigate to "Batch Element Entry"
	And navigate to "BEE Summary"
	And navigate to "Extract Definition"
	And navigate to "Layout Definition" 
	And navigate to "Criteria Definition"
	And navigate to "Extract Results"
	And navigate to "Change Event Log"
	And navigate to "Person Types"   
	And navigate to "Application Utilities Lookups" 
	And navigate to "Special Information Types"
	And navigate to "Table Structure"
	And navigate to "Table Values"
	And navigate to "Time Periods"   
	And navigate to "User Profile Options" 
	And navigate to "Formula Functions" 
	And navigate to "User Types and Statuses"
	And navigate to "Dynamic Triggers"
	And navigate to "Functional Areas"	  
	And navigate to "Third Party Payroll Balance Types"
	And navigate to "Third Party Payroll Org Run Results"
	And navigate to "Third Party Payroll Emp Run Results"
	And click "Person Name Formats" option  
	And navigate to "Profile" 
	And navigate to "Assign Security Profiles" 
	And navigate to "CustomForm"
	And navigate to "Information Types Security"
	And navigate to "Report Sets"
	And navigate to "Task Flow Nodes"
	And navigate to "Task Flow Definitions"   
	And navigate to "Forms Configurator"	
	And navigate to "Contexts"
	And navigate to "Transaction Status"
	And navigate to "Global Profile"


	@Oracle
Scenario: Abt US HRMS Manager: People
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HRMS Manager" option
	And navigate to "Enter and Maintain"
	And navigate to "Salary Management"
	And navigate to "Events and Bookings"
	And navigate to "Delete Personal Records"
	And navigate to "Manage Contracts"
	And click "Search Documents of Record" option		
	And navigate to "Hiring Applicants"
	And navigate to "Entering Employees"
	And navigate to "Maintaining Employees"
	And navigate to "Maintaining Visa"	
	And navigate to "Entering Contingent Workers"
	And navigate to "Maintaining Contingent Workers"	
	And navigate to "Person Benefits Balances"
	And navigate to "Person Benefits Assignments"
	And navigate to "COBRA Beneficiaries"	 
	And navigate to "Participation Overrides"	   
	And navigate to "View Enrollment Results"
	And navigate to "Non-flex Program"
	And navigate to "Savings Plan"
	And navigate to "Miscellaneous Plan"	 
	And navigate to "Enrollment Override"	
	And navigate to "Dependent/Beneficiary Designation"
	And navigate to "Person Primary Care Provider"
	And navigate to "Court Orders" 
	And navigate to "Person Communications"
	And navigate to "Person Life Events"
	And navigate to "Record Continuing Benefits Payment"	 
	And navigate to "Monthly Participant Premium"
	And navigate to "Monthly Premiums" 
	And navigate to "Manual Payments"
	And navigate to "Mass Update of Applicant Assignments"   
	And navigate to "Mass Update of Employee Assignments"


	@Oracle
Scenario: Abt US HRMS Manager: Fast Path
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HRMS Manager" option
	And navigate to "Absence"
	And navigate to "Accruals"
	And navigate to "Address"
	And navigate to "Application"
	And navigate to "Assignment"   
	And navigate to "Assignment Budget"
	And navigate to "Assignment Extra Information"
	And navigate to "Basic Benefits"
	And navigate to "Competence Profile"
	And navigate to "Contact"   
	And navigate to "Contracts" 
	And navigate to "End Application"
	And navigate to "End Employment"
	And navigate to "Entries"
	And navigate to "End Placement" 
	And navigate to "Grade Step"
	And navigate to "Pay Method"
	And navigate to "Person Extra Information"
	And navigate to "Person Type Usage"
	And navigate to "Communication Delivery Methods"   
	And navigate to "Phones"  
	And click "Picture" option
	And navigate to "Qualifications"   
	And navigate to "Salary History" 
	And navigate to "Special Information" 
	And navigate to "US/CA Address"
	And navigate to "Medical Assessments"
	And navigate to "Checklists" 
	And navigate to "Supplementary Roles"
	And navigate to "Previous Employment"   
	And navigate to "School/College Attendance"
	And navigate to "Assignment Rates"
	And click "Documents of Record" option
	And click "Salary" option
	And navigate to "Contact"
	And navigate to "Employee Review"
	And navigate to "Event"
	And navigate to "Secondary Status"
	

	@Oracle
Scenario: Abt US HRMS Manager: Recruitment and Career Management
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HRMS Manager" option
    And navigate to "Requisition and Vacancy"
	And navigate to "Recruitment Activity"   
	And navigate to "Applicant Quick Entry"
	And navigate to "Mass Update of Applicants"
	And navigate to "Request Recruitment Letter"
	And navigate to "Rating Scales"
	And navigate to "Competencies"   
	And navigate to "Competence Types"
	And navigate to "Competence Requirements"
	And navigate to "Schools & Colleges"
	And navigate to "Qualification Types"
	And navigate to "Assessment Template"   
	And navigate to "Appraisal Template" 
	And click "Upload Third Party Skills" option
	And click "Objectives Library" option   
	And click "Performance Management Plans" option 

	@Oracle
Scenario: Abt US HRMS Manager: Work Structures
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HRMS Manager" option
	And navigate to "Location"
	And click "Generic Hierarchy" option
	And navigate to "Status"   
	And navigate to "Recruitment Letter Type"
	And navigate to "Contract Letter Type"
	And navigate to "Elections"
	And navigate to "Collective Agreements and Grade Structures"
	And navigate to "Collective Agreements"
	And navigate to "Define Entitlement Item" 
	And navigate to "Define Collective Agreement"
	And navigate to "Define Collective Agreement Grades"
	And navigate to "Define Eligibility Profiles"
	And navigate to "Define Derived Factors"  
	And click on Description Organization
	And navigate to "Organization Manager"
	And navigate to "Hierarchy"
	And navigate to "Diagrammer"
	And navigate to "Global Hierarchy"
	And click "Hr Org Operating Unit Upload" option
	And click on Description Job 
	And navigate to "Career Path Names" 
	And navigate to "Career Path"
	And navigate to "Job Group"	
	And click on Description Position 
	And navigate to "Hierarchy"   
	And navigate to "Mass Move"
	And navigate to "Diagrammer"
	And navigate to "Position Transaction"
	And navigate to "Position Copy"
	And navigate to "Mass Position Update"   
	And click on Description Grade 
	And navigate to "Grade Rate" 
	And navigate to "Pay Scale"
	And navigate to "Point Values"   
	And navigate to "Grade Steps and Points"
	And click "Progression Approval" option
	And navigate to "Assignment Rate Types"
	And navigate to "Budget Worksheet"
	And navigate to "Budget Details"   
	And click "Budget Reallocation" option
	And navigate to "Budget Calendar"
	And navigate to "Budget Set"
	And navigate to "Budget Characteristics"
	And click "Budget Migration" option    
	And click "Shifts" option  
	And click "Schedule Patterns" option
	And click "Schedules" option
	And click "Category" option
	And click "Shift Detail Type" option
	And click "Global Exception" option  
	And click "Manage Eligibility Profiles" option
	And click "Enter and Maintain Events" option
	And click "Review Calendar Event Coverage" option  
	And click "Review Applicable Events" option
	And navigate to "Eligibility Profiles"
	And click "Setup/Maintain Checklists" option


	@Oracle
Scenario: Abt US HRMS Manager: Payroll and Total Compensation
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HRMS Manager" option
	And click on Description Payroll	
	And navigate to "Consolidation" 
	And navigate to "Payment Methods"
	And navigate to "GL Flexfield Map"
	And navigate to "Update Payroll Run"
	And navigate to "Assignment Set"
	And navigate to "Element Set" 
	And navigate to "RetroPay Set" 
	And navigate to "GL Daily Rates"
	And navigate to "Conversion Rate Types"
	And navigate to "Monetary Units"
	And navigate to "Balance Set"
	And click "Total Compensation Setup Wizard" option  
	And navigate to "Element Description"
	And navigate to "Link"
	And navigate to "Earnings"
	And navigate to "Tax Withholding Rules"
	And navigate to "Salary Basis"   
	And navigate to "Compensation Survey" 
	And navigate to "Benefit Contributions"
	And navigate to "Absence Types"
	And navigate to "Accrual Plans"
	And navigate to "Write Formula"
	And navigate to "Global Values"
	And navigate to "Balance"
	And navigate to "Benefits Group"
	And navigate to "Benefit Balances"
	And navigate to "Derived Factors"
	And navigate to "Postal/Zip"
	And navigate to "Service Areas"   
	And navigate to "Participant" 
	And navigate to "Dependent Coverage"
	And click "Maintain Eligibility Criteria" option	
	And navigate to "Program/Plan Years"
	And navigate to "Regulations"
	And navigate to "Reporting Groups"   
	And navigate to "Goods and Services" 
	And navigate to "Communication Types"
	And navigate to "Life Event Reasons"
	And navigate to "View Program Structure"   
	And navigate to "Plan Types" 
	And navigate to "Options"
	And navigate to "Plans"
	And navigate to "Plan Enrollment Requirements"
	And navigate to "Plan Primary Care Providers"   
	And navigate to "Programs" 
	And navigate to "Program Enrollment Requirements"
	And click "Plan Design Copy" option
	And navigate to "Plan Third Party Identifier"
	And navigate to "Variable Rate Profiles"
	And navigate to "Standard Rates"   
	And navigate to "Period-to-date Limits" 
	And navigate to "Coverage Calculations"
	And navigate to "Coverage Across Plan Types"
	And navigate to "Actual Premiums"
	And navigate to "Imputed Income"   
	And click "Maintain Criteria Rate Definition" option
	And click "Maintain Rate Matrix" option	


	@Oracle
Scenario: Abt US HRMS Manager: View to Security  
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt US HRMS Manager" option
	And navigate to "Vacancies"
	And navigate to "Grade Comparatio"
	And navigate to "Employee Accruals" 
	And navigate to "Employee Balances"
	And navigate to "Tax Balances"
	And navigate to "Payroll Process Results"
	And navigate to "Assignment Process Results"
	And navigate to "System Messages"
	And click "Retropay Status" option	
	And navigate to "Worker Assignment"   
	And navigate to "Absence" 
	And navigate to "Run Results" 
	And click on SalaryB 
	And navigate to "Entries"
	And navigate to "Contribution History (Def Comp 457)"
	And navigate to "People Folder"   
	And navigate to "Assignment Folder" 
	And navigate to "People by Assignment"
	And navigate to "Assignments"
	And navigate to "Workforce by Organization"
	And navigate to "Workforce by Position"
	And navigate to "Workforce by Position Hierarchy"   
	And navigate to "Employees by Element" 
	And navigate to "Employees by Absence Type" 
	And navigate to "People by Special Information"
	And navigate to "Submit Processes and Reports"
	And navigate to "View Requests"
	And navigate to "View Reports"
	And click "Workflow Notifications" option   
	And navigate to "Batch Process Parameters" 
	And navigate to "Monitor Batch Processes"	
	And navigate to "Define a Quickpaint Report"
	And navigate to "Run a Quickpaint Report"
	And navigate to "Submit Custom Reports"
	And navigate to "Process Log" 	
	And navigate to "Roles"
	And navigate to "Routing Lists"
	And click "Configurable Business Rules" option
	And navigate to "Templates"
	And navigate to "Transaction Type Wizard"   
	And navigate to "Global Roles" 
	And click "Document Management" option
	And navigate to "Transaction Categories"  
	And navigate to "Batch Element Entry"
	And navigate to "BEE Summary"
	And click "BEE Spreadsheet Interface" option
	And click "BBA Spreadsheet Interface" option
	And navigate to "Layout Definition" 
	And navigate to "Criteria Definition"
	And navigate to "Extract Definition"	
	And navigate to "Extract Results"
	And navigate to "Change Event Log"
	And navigate to "Person Types"   
	And navigate to "Application Utilities Lookups" 
	And navigate to "Special Information Types"
	And navigate to "Define Cities"
	And navigate to "Table Structure"
	And navigate to "Table Values"
	And navigate to "Time Periods"   
	And navigate to "User Profile Options" 
	And navigate to "User Types and Statuses"
	And navigate to "Dynamic Triggers"
	And navigate to "Functional Areas"	  
	And navigate to "Define Event Group"
	And click "Configuration Values" option  
	And click "Person Name Formats" option 
	And click "Dynamic Time Periods" option 
	And click "Reports" option 
	And click "Groups" option 
	And click "Concurrent Request Monitoring/Viewing" option 
	And navigate to "Profile" 
	And navigate to "Assign Security Profiles" 
	And navigate to "CustomForm"
	And navigate to "Information Types Security"
	And navigate to "Report Sets"
	And navigate to "Task Flow Nodes"
	And navigate to "Task Flow Definitions"   
	And navigate to "Forms Configurator"	
	And navigate to "Contexts"
	And navigate to "Transaction Status"
	And navigate to "Task Flow Units"
	And navigate to "Global Profile"

	
	@Oracle
Scenario: HR: Manage Employee Action Forms
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "HR: Manage Employee Action Forms" option
	And click "Employee Overview" option
	And click "Employee Hours Change" option
	And click "Change Timecard Approver and Supervisor" option
	And click "Offboard Employee" option
	And click "Notifications" option
	And click "Discoverer Viewer" option 


	@Oracle
Scenario: Workflow User Web Applications
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Workflow User Web Applications" option
	And click "Worklist" option
	And click "Find Processes" option

