Feature: Oracle
		In order to Ensure the Estability of
		Our ERP
		I Want To Perform a Functioal Test

@oracle
Scenario: Oracle Sign in
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And put my user and password
	Then click iProcurement request and then Non-Catalog Req
	And fill the request form
	Then Checkout the cart
	And Fill Requisition Information