Feature: WinPrograms
	Test the network response time for windows apps 

@Outlook
Scenario: Microsoft Outlook Test
	Given   i opened Outlook
	Then    Outlook is logged with my Windows credentials

@SkypeForBusiness
Scenario: Skype For Business Test
	Given i have logged to Windows 
	Then  Skype for Business opened with my user
