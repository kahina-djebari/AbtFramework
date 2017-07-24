Feature: WinPrograms
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


@Outlook
Scenario: Microsoft Outlook Test
	Given   i opened Outlook
	Then    Outlook is logged with my Windows credentials

@SkypeForBusiness
Scenario: Skype For Business Test
	Given i have logged to Windows 
	Then  Skype for Business opened with my user
