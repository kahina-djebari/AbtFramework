﻿Feature: OracleDiscReportMultipleSheets
	In order to complete a Oracle Discoverer Reports
	with Multiple sheets - HRIS Actor.

@Oracle
Scenario: Oracle Discoverer Report with Multiple Sheets
	Given I have Open IE Test
	And I have navigated to Oracle Dev
	And i login as "Lisa Butterfield"
	Then click the "Abt HR User" option
	Then click the "Discoverer Viewer" option
	Then I do discoverer books for multiple sheets


