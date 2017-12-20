using System;
using AbtFramework.Utils_Classes;
using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AbtFramework
{
    public class ITServiceRequestpage : PageModel
    {
        [FindsBy(How=How.Id,Using = "item_link_023c32749c224200615ec5391ae8d83e")]
        private IWebElement Incident;
        [FindsBy(How=How.LinkText,Using ="Ask a Question")]
        private IWebElement AskQuestion;
        [FindsBy(How=How.LinkText,Using = "Conferencing Setup")]
        private IWebElement conferencingSetupLink;
        [FindsBy(How = How.LinkText, Using = "Distribution List Request")]
        private IWebElement DistributionListLink;

        public void NewIncident(IncidentType incident)
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            switch (incident)
            {
                case IncidentType.Ask_A_Question:
                    wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                    wait.Until(e => AskQuestion.Displayed);
                             AskQuestion.Click();

                    break;
                case IncidentType.IT_Incident:
                    wait.Until(e => Incident.Displayed);
                    Incident.Click();
                   // AbtDriver.NewIncidentPage.NewIncident(priority, shortdescription, description);
                    break;
                case IncidentType.ConferencingSetup:
                    wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                    wait.Until(e => conferencingSetupLink.Displayed);
                    conferencingSetupLink.Click();

                    break;
                case IncidentType.DistributionListRequest:

                    wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                    wait.Until(e => DistributionListLink.Displayed);
                    DistributionListLink.Click();
                    break;
                case IncidentType.HardwarePeripheralRequest:
                    break;
                case IncidentType.SoftwareRequest:
                    break;
                case IncidentType.Contractor_Consultant_TempOffBoarding:
                    break;
                default:
                    break;
            }


        }
    }
}