using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class ServiceNowIRRForm : PageModel
    {
        [FindsBy(How=How.Id,Using = "sys_readonly.u_incident_response.number")]
        public IWebElement IRNumber;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_event_summary")]
        public IWebElement _eventSummary;

        [FindsBy(How=How.Id,Using = "sys_display.u_incident_response.parent")]
        private IWebElement ParentIncident;
        [FindsBy(How=How.Id,Using = "u_incident_response.state")]
        private IWebElement State;
        [FindsBy(How=How.Id,Using = "sys_display.u_incident_response.u_project_dir")]
        private IWebElement PD;
        [FindsBy(How = How.Id, Using = "sys_display.u_incident_response.u_reporter")]
        private IWebElement _incidentReporter;
        [FindsBy(How=How.Id,Using = "sys_display.u_incident_response.u_supervisor")]
        private IWebElement Sup;
        [FindsBy(How=How.Id,Using = "u_incident_response.u_event_start")]
        private IWebElement _eventStartTime;
        [FindsBy(How=How.Id,Using = "u_incident_response.u_event_discovered")]
        private IWebElement _eventDiscovered;
        [FindsBy(How=How.Id,Using = "u_incident_response.u_itsc_irb_notified")]
        private IWebElement _ITSCNotified;
        [FindsBy(How = How.Id, Using = "sys_display.u_incident_response.assigned_to")]
        private IWebElement _assignedTO;
        [FindsBy(How = How.Id, Using = "sys_display.u_incident_response.u_affected_area")]
        private IWebElement _departments;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_client")]
        private IWebElement _clientName;
        [FindsBy(How=How.Id,Using = "u_incident_response.short_description")]
        private IWebElement _shortDescription;
        [FindsBy(How = How.Id, Using = "u_incident_response.description")]
        private IWebElement _description;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_num_rec_affected")]
        private IWebElement ReccordAffected;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_incident_data_ownership")]
        private IWebElement DataOwnership;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_disclosing_party")]
        private IWebElement DisclosingParty;
        [FindsBy(How = How.ClassName, Using = "tab_caption_text")]
        private IList<IWebElement> Tabs;
        [FindsBy(How = How.Id, Using = "label.ni.u_incident_response.u_recipients_authorized")]
        private IWebElement AllRecipientsAuthorized;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_actual_start_time")]
        private IWebElement _actualStartTime;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_actual_dicovered")]
        private IWebElement _actualDiscovered;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_resp_plan_start")]
        private IWebElement _responsePlanActivated;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_incident_contained")]
        private IWebElement _incidentContained;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_event_class")]
        private IWebElement EventClassification;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_mitigation_date")]
        private IWebElement _dateOfMitigation;
        [FindsBy(How = How.Id, Using = "u_incident_response.u_mitigation")]
        private IWebElement _mitigation;
        [FindsBy(How = How.ClassName, Using = "outputmsg_text")]
        private IList<IWebElement> IRRSubmitionOutputMsg;
        [FindsBy(How = How.Id, Using = "label.ni.u_incident_response.u_type_pii")]
        private IWebElement PII;
        [FindsBy(How=How.Id,Using = "label.ni.u_incident_response.u_data_ssn")]
        private IWebElement SSNChecBox;
        [FindsBy(How=How.Id,Using = "label.ni.u_incident_response.u_disc_email")]
        private IWebElement EmailChecBox;
        [FindsBy(How=How.Id,Using = "label.ni.u_incident_response.u_inctype_info")]
        private IWebElement InfDisclosureBox;

        public string ProjectDirector { set { PD.SendKeys(value); } }

        public string IncidentReporter { set { _incidentReporter.SendKeys(value); } }

        public string EventSummary { set { _eventSummary.SendKeys(value); } }

        public string Supervisor { set { Sup.SendKeys(value); } }

        public string EventStartTime { set { _eventStartTime.SendKeys(value); } }

        public string EventDiscovered { set { _eventDiscovered.SendKeys(value); } }

        public string ITSCNotified { set { _ITSCNotified.SendKeys(value); } }

        public string AssignedTo { set { _assignedTO.SendKeys(value); } }

        public string Departments { set { _departments.SendKeys(value); } }

        public string ClientName { set { _clientName.SendKeys(value); } }

        public string ShortDescription { set { _shortDescription.SendKeys(value); } }

        public string Description { set { _description.SendKeys(value); } }

        public IWebElement SenderRecipientTab { get { return Tabs.Single(e => e.Text.Equals("Sender / Recipient")); } }

        public IWebElement EventDetails { get { return Tabs.Single(e => e.Text.Equals("Event Details")); } }

        public string ActualStartTime { set { _actualStartTime.SendKeys(value); } }

        public string ActualDiscovered { set { _actualDiscovered.SendKeys(value); } }

        public string ResponsePlanActivated { set { _responsePlanActivated.SendKeys(value); } }

        public string IncidentContained { set { _incidentContained.SendKeys(value); } }

        public string DateOfMitigation { set { _dateOfMitigation.SendKeys(value); } }

        public string Mitigation { set { _mitigation.SendKeys(value); } }


        public void FillWithDefaultValues()
        { 
            MyIRRSubmition.SetNumber(IRNumber.GetAttribute("value"));
        }

        public string GetId()
        {
            return IRNumber.GetAttribute("value");
        }

        public string GetParentIncident()
        {
            return ParentIncident.GetAttribute("value");
        }

        public void UpdateIRRState(string state)
        {
            State.SelectOption(state).Click();
        }

        public void OpenIRRTab(string tab)
        {
           Tabs.Single(e => e.Text.Equals(tab)).Click();
        }

      // public IWebElement SenderRecipientTab { get { return Tabs.Single(e => e.Text.Equals("Sender / Recipient")); } }

        public void FillMandatoryFields()
        {   //ProjectDirector or Supervisor (for the QA) change, they must be updated here too.
            ProjectDirector = "Michael Wasielewski";
            Supervisor = "Sofiane Oumsalem";
            //due the execution order the ticked will be taken from a parent and therfore 
            //this field is already populated. 
            //IncidentReporter="Jose Frometa Guerra";
            EventStartTime = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            EventDiscovered = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            ITSCNotified = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            AssignedTo = "Stella Laidoson";
            Departments = "IT";
            ClientName = "NA";
            //select drop down option
            DisclosingParty.SelectOption("Abt Employee").Click();
            ShortDescription = "test short description";
            Description = "test description";
            EventSummary = "Some Test Text";
            OpenEventDetails();
            ReccordAffected.SelectOption("Unknown").Click();
            //generic function to switch between tabs
            OpenIRRTab("Sender / Recipient");
            AllRecipientsAuthorized.Click();
            OpenIRRTab("Incident Response Team");
            //Select drop down property
            DataOwnership.SelectOption("Client").Click();
            ActualStartTime = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            ActualDiscovered= DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss"); 
            ResponsePlanActivated= DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            IncidentContained= DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            EventClassification.SelectOption("Event").Click();
            DateOfMitigation= DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            Mitigation = "test mitigation";
            OpenIRRTab("Event Details");
            
        }

        public void CheckRequiredBoxes()
        {
            SetTypesOfInformation("PII");
            SetTypesOfDataInvolved("SSN");
            SetDeviceInvolved("Email");
            //generic switches the tab to String param
            OpenIRRTab("Incident Response Team");
            SetIncidentType("Information Disclosure");


        }

        private void SetIncidentType(string incidentType)
        {
            switch (incidentType)
            {
                case "Information Disclosure":
                    InfDisclosureBox.Click();
                    break;
                default:
                    break;
            }
        }

        private void SetDeviceInvolved(string deviceInvolved)
        {
            switch (deviceInvolved)
            {
                case "Email":
                    EmailChecBox.Click();
                    break;
                default:
                    break;
            }
        }

        private void SetTypesOfDataInvolved(string typeOfDataInvolved)
        {
            switch (typeOfDataInvolved)
            {
                case "SSN":
                    SSNChecBox.Click();
                    break;
                default:
                    break;
            }
        }

        private void SetTypesOfInformation(string typeOfInfo)
        {
         
            switch (typeOfInfo)
            {
                case "PII":
                    PII.Click();
                    break;
                default:
                    break;
            }

        }

        public string GetInvalidUpdateErrorMsg()
        {
            return IRRSubmitionOutputMsg[1].Text;
        }

        public bool InvalidUpdateFired()
        {
            try
            {
                IRRSubmitionOutputMsg.Single(e => e.Text.Equals("Invalid update"));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        
        private void OpenSenderRecipientTab()
        {
            SenderRecipientTab.Click();
        }

        private void OpenEventDetails()
        {
            EventDetails.Click();
        }
    }
}