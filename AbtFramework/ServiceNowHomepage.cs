using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AbtFramework
{
    public class ServiceNowHomepage : PageModel
    {
        [FindsBy(How=How.Id,Using = "ok_button")]
        private IWebElement OkBtn;

        [FindsBy(How=How.CssSelector,Using = "#impersonate_span > span")]
        private IWebElement UserIcon;

        [FindsBy(How = How.Id, Using = "imp_recent")]
        private IWebElement Users;

           

        [FindsBy(How=How.Id,Using = "gsft_full_name")]
        private IWebElement CurrentUser;

        [FindsBy(How = How.ClassName, Using = "nav-wrapper")]
        private IWebElement RoleList;

        [FindsBy(How=How.Id,Using = "25edd9529cfac200615ec5391ae8d86c")]
        private IWebElement ServiceHub;   

        private Dictionary<string,string[]> rolesDictionary;

        [FindsBy(How=How.ClassName,Using = "list2_body")]
        private IWebElement UnassignedFacilitiesTable;

        [FindsBy(How = How.ClassName, Using = "breadcrumb_link")]
        private IWebElement filterLink;

        private IWebElement LatestRequest;
        [FindsBy(How=How.Id,Using = "link.facilities_request.time_worked")]
        private IWebElement timeworked;

        

        [FindsBy(How=How.Id,Using = "readyForWork")]
        private IWebElement ReadyForWork;

        [FindsBy(How=How.Id,Using = "facilities_request.work_notes")]
        private IWebElement FacilityWorknotes;
        [FindsBy(How=How.Id,Using = "sysverb_update")]
        private IWebElement Update;
        [FindsBy(How=How.Id,Using = "sys_display.facilities_request.assigned_to")]
        private IWebElement Facility_AssigntoPerson;

        [FindsBy(How = How.Id, Using = "sys_display.u_hr_service_tracking.u_assigned_to")]
        private IWebElement AssignToHRPerson;


        [FindsBy(How=How.LinkText,Using ="Created")]
        private IWebElement OrderByCreated;
        [FindsBy(How=How.Id,Using = "u_hr_service_tracking.u_comments")]
        private IWebElement AdditionalComments;
        [FindsBy(How = How.Id, Using = "u_hr_service_tracking.u_work_notes")]
        private IWebElement HRworkNotes;
        [FindsBy(How=How.LinkText,Using = "My Work")]
         private IWebElement myWorLink;
        [FindsBy(How=How.LinkText,Using ="My Groups Work")]
        private IWebElement myGroupsWorkLink;
        [FindsBy(How=How.LinkText,Using ="Service Desk")]
        private IWebElement ServiceDeskLink;

      

      
        [FindsBy(How=How.Id,Using = "incident.category")]
        private IWebElement ITCategory;
        [FindsBy(How = How.Id, Using = "sys_display.incident.u_itsc_first_responder")]
        private IWebElement ITSCResponder;
        [FindsBy(How = How.Id, Using = "incident.subcategory")]
        private IWebElement ITSubCategory;
        [FindsBy(How = How.Id, Using = "incident.u_type")]
        private IWebElement ITType;
        [FindsBy(How=How.Id,Using = "incident.comments")]
        private IWebElement IncidentComments;
        [FindsBy(How = How.Id, Using = "resolve_incident")]
        private IWebElement ResolveIncident;
        [FindsBy(How=How.Id,Using = "link.incident.time_worked")]
        private IWebElement TimeworkedOnIncident;
        [FindsBy(How=How.Id,Using = "b55fbec4c0a800090088e83d7ff500de")]
        private IWebElement IncidentOpen;
        [FindsBy(How = How.Id, Using = "cf30af240a0a0b3000ab68fbb64877c9")]
        private IWebElement IncidentResolved;



        [FindsBy(How = How.Id, Using = "54f3f8b704df110008e999502af6ec9f")]
        private IWebElement HR_Issues_Open;
        [FindsBy(How = How.Id, Using = "incident.contact_type")]
        private IWebElement contactType;
        [FindsBy(How=How.Id,Using = "incident.short_description")]
        private IWebElement ShortDescription;
        [FindsBy(How=How.Id,Using = "incident.description")]
        private IWebElement Description;
        [FindsBy(How = How.Id, Using = "incident.urgency")]
        private IWebElement urgencySelected;
        private int urgencyValue;
        [FindsBy(How = How.Id, Using = "ni.incident.u_request")]
        private IWebElement Request;
        [FindsBy(How = How.Id, Using = "sys_display.incident.assignment_group")]
        private IWebElement AssignmentGroup;
        [FindsBy(How = How.Id, Using = "sys_readonly.incident.number")]
        private IWebElement IncidentNumber;
        [FindsBy(How = How.ClassName, Using = "menu")]
        private IList<IWebElement> menuLinks;

        public string GetErrorMsg()
        {
            return OutputMsg;
        }

        [FindsBy(How=How.Id,Using = "incident.impact")]
        private IWebElement impactSelected;
        [FindsBy(How=How.Id,Using = "u_hr_service_tracking.u_status")]
        private IWebElement StatusDropdown;

        public void WaitForHomePageToLoad()
        {
            wait.Until(e => CurrentUser.Displayed);
            StopTimer();
        }

        [FindsBy(How=How.Id,Using = "4161db8730a29a00615eb46830c88978")]
        private IWebElement facilityRequests;

        public string GetResponseTime()
        {
            return LoadTime;
        }

        [FindsBy(How=How.Id,Using = "closeComplete")]
        private IWebElement closeComplete;
        [FindsBy(How=How.Id,Using = "startWork")]
        private IWebElement StartWork;
        [FindsBy(How=How.Id,Using = "sysverb_new")]
        private IWebElement NewTicket;
        [FindsBy(How=How.Id,Using = "sys_display.incident.caller_id")]
        private IWebElement caller;
        [FindsBy(How = How.Id, Using = "sys_display.incident.u_itsc_first_responder")]
        private IWebElement ITFirstResponder;
        [FindsBy(How=How.Id,Using = "sysverb_insert")]
        private IWebElement submitbtn;

        [FindsBy(How = How.Name, Using = "incident.work_notes")]
        private IWebElement ITworkNotes;
        [FindsBy(How=How.Id,Using = "sys_display.u_hr_service_tracking.u_employee_name")]
        private IWebElement EmployeeName;
        [FindsBy(How=How.Id,Using = "u_hr_service_tracking.u_category")]
        private IWebElement HR_IssueCategoryDropdown;
        [FindsBy(How = How.Id, Using = "u_hr_service_tracking.u_short_description")]
        private IWebElement HR_Subject;
        [FindsBy(How=How.Id,Using = "u_hr_service_tracking.u_description")]
        private IWebElement HR_Description;
        [FindsBy(How=How.Id,Using = "u_hr_service_tracking.u_contact_method")]
        private IWebElement HR_ContactMethod;
        [FindsBy(How=How.Id,Using = "sys_display.facilities_request.caller")]
        private IWebElement Facility_Caller;
        [FindsBy(How = How.Id, Using = "facilities_request.category")]
        private IWebElement Facility_Category;
        [FindsBy(How = How.Id, Using = "facilities_request.u_subcategory")]
        private IWebElement Facility_SubCategory;
        [FindsBy(How = How.Id, Using = "facilities_request.short_description")]
        private IWebElement Facility_ShortDescription;
        [FindsBy(How = How.Id, Using = "sys_display.facilities_request.assignment_group")]
        private IWebElement Facility_AssignmentGroup;
        [FindsBy(How = How.Id, Using = "tmr_4fdce1b12ba56200fccbf62219da1561_img")]
        private IWebElement Facilitytimeworked;
        [FindsBy(How=How.Id,Using = "d78ed921ff4221009b20ffffffffffdf")]
        private IWebElement NewArticle;
        [FindsBy(How=How.Id,Using = "kb_knowledge.short_description")]
        private IWebElement KB_ShortDescription;
        [FindsBy(How=How.Id,Using ="tinymce")]
        private IWebElement KBArticleBody;
        private static string SSOProvider;
        private static string portalEnvironment;
        [FindsBy(How=How.Id,Using = "nav_header_text")]
        private IWebElement header;
        [FindsBy(How=How.LinkText,Using ="Incident Response Report")]
        private IWebElement IRR;
        [FindsBy(How=How.Id,Using = "div.a0c997b64f03e200ff2d85c98310c799")]
        private IWebElement IRRSection;
        [FindsBy(How=How.ClassName,Using ="outputmsg_text")]
        private IWebElement _outputMsg;

        ////////////////////////////////////////////////////////////////////////
        
        //  ITSC WEBELEMNS

        [FindsBy(How = How.LinkText, Using = "Incident")]
        private IWebElement ITSCIncidentDropDownTitle;
        [FindsBy(How = How.Id, Using = "div.dead1309c611228701e2bda7b4252474")]
        private IWebElement IncidentSectionDropDownTitle;
        [FindsBy(How = How.Id, Using = "14641d70c611228501114133b3cc88a1")]
        private IWebElement CreateNewIncidentButton;
        [FindsBy(How = How.Id, Using = "incident.comments")]
        private IWebElement AdditionalCommentsInputField;
        [FindsBy(How = How.Id, Using = "tmr_157c71e64f26b2001b0bee6d0210c7fd_min")]
        private IWebElement MinutesWorkedInputField;

        ////////////////////////////////////////////////////////////////////////

        public IWebElement SelfServiceContact { get { return contactType.FindElements(By.TagName("option"))
                                                                 .Single(e => e.Text.Equals("Self-service")); } }

        public IWebElement UrgencySelected {
            get
            {
                return urgencySelected.FindElements(By.TagName("option"))
                               .Single(e => e.GetAttribute("selected") !=null &&
                               e.GetAttribute("selected").Equals("true"));
            }
        }

        public IWebElement ServiceHubHomeLink { get { return menuLinks.Single(e => e.Text.Equals("Home")); } }

        public IWebElement ImpactSelected
        {get
            {
                return impactSelected.FindElements(By.TagName("option"))
                                .Single(e => e.GetAttribute("selected") != null &&
                                e.GetAttribute("selected").Equals("true"));
            }
        }

        public string OutputMsg { get { return _outputMsg.Text; } }

        public void OpenIRRSection()
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_nav");

            wait.Timeout = TimeSpan.FromSeconds(5);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            SeleniumDriver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            wait.Until(e =>
            {

                try
                {
                    IRR.Click();
                    return true;
                }

                catch(Exception ex)
                {
                    
                    ExpandIRRSection();
                    return false;
                }
              
        
               
            });
            SeleniumDriver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
           
        }

        private void FillAdditionalComments()
        {
            AdditionalCommentsInputField.SendKeys(" ITSC Input Test Text: Update");
        }

        private void FillWorkedMinutes()
        {
            MinutesWorkedInputField.SendKeys("05");
        }

        private void ExpandIRRSection()
        {
            IRRSection.Click();
        }

        public void UpdateITSCIncident()
        {
            TimeworkedOnIncident.Click();
            Thread.Sleep(1000);
            FillAdditionalComments();
            //FillWorkedMinutes();
            Update.Click();
        }

        public void ResolveITSCIncident()
        {
            TimeworkedOnIncident.Click();
            Thread.Sleep(1000);
            FillAdditionalComments();
            //FillWorkedMinutes();
            ResolveIncident.Click();
        }

        public void OpenHRIssues()
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_nav");

            HR_Issues_Open.Click();

        }
        public void OpenKnowledgeBase()
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_nav");
            NewArticle.Click();


        }

        public void CreateNewHRTicket(string EmpName, string IssueCategory, string Subject, string Description, string ContactMethod)
        {
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            NewTicket.Click();
            EmployeeName.SendKeys(EmpName);
            HR_IssueCategoryDropdown.SelectOption(IssueCategory).Click();
            HR_Subject.SendKeys(Subject);
            HR_Description.SendKeys(Description);
            HR_ContactMethod.SelectOption(ContactMethod).Click();
            HRworkNotes.SendKeys("HR Ticket Creation at:" + DateTime.Now);
            submitbtn.Click();
        }

        public string CreateNewIncident(string callerfield, string Category, string subCategory, string Type, string ITSCResponder, string assigmentGroup)
        {
           
            NewTicket.Click();
            string IncidentID = IncidentNumber.GetAttribute("value");
            caller.SendKeys(callerfield);
            TimeworkedOnIncident.Click();
           
            ITCategory.SelectOption(Category).Click();
            Thread.Sleep(1000);
            ITSubCategory.SelectOption(subCategory).Click();
            Thread.Sleep(1000);
            ITType.SelectOption(Type).Click();
            ITFirstResponder.SendKeys(ITSCResponder);
            action.SendKeys(Keys.Tab).Perform();
            AssignmentGroup.SendKeys(assigmentGroup);
            action.SendKeys(Keys.Tab).Perform();
            Thread.Sleep(1500);
            //            ITworkNotes.SendKeys("Test Incident Request from service now");
            //TimeworkedOnIncident.Click();
         //   action.SendKeys(Keys.Tab).Perform();
            submitbtn.Click();
            return IncidentID;
            
        }

        public string CreateNewIncidentITSC(string callerfield, string Category, string subCategory, string Type, string ITSCResponder, string assigmentGroup)
        {
            
            string IncidentID = IncidentNumber.GetAttribute("value");
            caller.SendKeys(callerfield);
            TimeworkedOnIncident.Click();

            ITCategory.SelectOption(Category).Click();
            Thread.Sleep(1000);
            ITSubCategory.SelectOption(subCategory).Click();
            Thread.Sleep(1000);
            ITType.SelectOption(Type).Click();
            ITFirstResponder.SendKeys(ITSCResponder);
            action.SendKeys(Keys.Tab).Perform();
            AssignmentGroup.SendKeys(assigmentGroup);
            action.SendKeys(Keys.Tab).Perform();
            Thread.Sleep(1500);
            //            ITworkNotes.SendKeys("Test Incident Request from service now");
            //TimeworkedOnIncident.Click();
            //   action.SendKeys(Keys.Tab).Perform();
            submitbtn.Click();
            return IncidentID;

        }

        public bool IsAt()
        {
            try
            {
                wait.Until(e => header.Displayed);
                StopTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Check if Welcome Message is Displayed"))
                {
                    if (TestCaseGenerator.CurrentTestCase.IsResponseTimeRequired)
                    {
                        TestCaseGenerator.CurrentTestCase.SetResponseTime(timer2 - timer1);
                        TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Check if Welcome Message is Displayed");
                    }
                }


                return true;
            }

            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Check if Welcome Message is Displayed"))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Check if Welcome Message is Displayed", ex.Message);

                throw (ex);
            }

            
          
        }

        public void CreateNewFacilityRequest(string caller, string category, string subcategory, string shortdescription, string assigmentgroup)
        {
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            NewTicket.Click();
            Facility_Caller.SendKeys(caller);
            Facility_Category.SelectOption(category).Click();
            Thread.Sleep(1000);
            Facility_SubCategory.SelectOption(subcategory).Click();
            Facility_ShortDescription.SendKeys(shortdescription);
            Facility_AssignmentGroup.SendKeys(assigmentgroup);
            Facilitytimeworked.Click();
            FacilityWorknotes.SendKeys("Facility Request Created at:" + DateTime.Now);
            submitbtn.Click();

        }

        public void CreateNewKBArticle(string shortdescription)
        {
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            KB_ShortDescription.SendKeys(shortdescription);
            action.SendKeys(Keys.Tab).Perform();
            action.SendKeys(Keys.Tab).Perform();
      

        }


        public bool isRoleCorrect(string user)
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_nav");
            FillRoles();
            string[] RoleForUser;
            var rolesContainer = GetRoleList();
            Console.WriteLine(rolesDictionary[user]);
            if (rolesContainer.Count() > 0)
            {
                if (rolesDictionary.TryGetValue(user, out RoleForUser))
                {

                    foreach (var roleContainer in rolesContainer)
                    {

                        Console.WriteLine(roleContainer.GetAttribute("id"));
                        string role = GetRoleText(roleContainer);
                        Console.WriteLine(role);
                        if (!RoleForUser.Contains(role) && role!="")
                        {
                            Console.WriteLine("Could not found role \"" + role + "\"");
                            return false;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Couldn't Find User \"" + user + "\" in the Dictonary");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No Roles Found On the page for User \"" + user + "\"");
            }

            return true;

          
           
            
        }

        public bool IncidentExist(IncidentType incidentType,Urgency urgency, string shortDescription, string MoreInformation)
        {
                      
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            AbtPages.TablePageObject.FirstRowItem.Click();
       

            if (!SelfServiceContact.Selected)
            {
                Console.WriteLine("Self Service is not Selected on Contact Type");
                Console.WriteLine("Incident info doesn't match with values found on Incident: " + IncidentNumber.GetAttribute("value"));
                return false;
            }

            if (!ShortDescription.GetAttribute("value").Equals(shortDescription))
            {
                Console.WriteLine("Short Description shown on this incident is not the same as the incident just created before");
                Console.WriteLine(ShortDescription.Text);
                Console.WriteLine("Incident info doesn't match with values found on Incident: " + IncidentNumber.GetAttribute("value"));
                return false;
            }

            if (!Description.Text.Equals(MoreInformation))
            {
                Console.WriteLine("Description shown on this incident is not the same as the incident just created before");
                Console.WriteLine("Incident info doesn't match with values found on Incident: " + IncidentNumber.GetAttribute("value"));
                return false;
            }

            switch (incidentType)
            {
                case IncidentType.Ask_A_Question:
                    if (!UrgencySelected.Text.Split('-')[1].Trim().Equals(urgency.ToString()))
                    {
                        Console.WriteLine("Urgency shown on this incident is not the same as the incident just created before");
                        Console.WriteLine(UrgencySelected.GetAttribute("value"));
                        Console.WriteLine("Incident info doesn't match with values found on Incident: " + IncidentNumber.GetAttribute("value"));
                        return false;
                    }
                    break;
                case IncidentType.IT_Incident:

                    if (!ImpactSelected.Text.Split('-')[1].Trim().Equals(urgency.ToString()))
                    {
                        Console.WriteLine("Impact shown on this incident is not the same as the incident just created before");
                        Console.WriteLine(UrgencySelected.GetAttribute("value"));
                        Console.WriteLine("Incident info doesn't match with values found on Incident: " + IncidentNumber.GetAttribute("value"));
                        return false;
                    }
                    break;
           
                default:
                    break;
            }
          
          
             if (!Request.GetAttribute("checked").Equals("true"))
            {
                Console.WriteLine("Request is not checked");
                Console.WriteLine("Incident info doesn't match with values found on Incident: " + IncidentNumber.GetAttribute("value"));
                return false;
            }

            if (!AssignmentGroup.GetAttribute("value").Equals("SD_General_IT"))
            {

                Console.WriteLine("Assignment Group Should be SD_General_IT ");
                Console.WriteLine("Incident info doesn't match with values found on Incident: " + IncidentNumber.GetAttribute("value"));
                return false;

            }
            
            return true;

        }

        public void FacilityRequests()
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_nav");
            facilityRequests.Click();
        }

        public void OpenIncidentSection()
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_nav");
            // IncidentSection.Click();
            Thread.Sleep(1000);
            IncidentOpen.Click();
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
        }

        public void ResolvedIncidentSection()
        {
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_nav");
            // IncidentSection.Click();
            Thread.Sleep(1000);
            IncidentResolved.Click();
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
        }

        public bool IsAtResolved()
        {
            return filterLink.Displayed;
        }
        public void CreateNewIncidentSection()
        {


            SeleniumDriver.Instance.SwitchTo().Frame("gsft_nav");
            // IncidentSection.Click();
            Thread.Sleep(1000);
            CreateNewIncidentButton.Click();
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
        }

        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                    GotoUrl("https://abtassoctest.service-now.com/navpage.do");
                   // GotoUrl("https://abtassociates.okta.com/home/servicenow_app2/0oa80tx9crDmIcRfk0x7/14155");
                  //  Console.WriteLine("Service Now (Test) Home Page Took: " + LoadTime + " to load Using Okta");
                 //   Console.WriteLine("</br>");
                    SSOProvider = "Okta";
                    portalEnvironment = "Test";
                    break;
                case WebEnvironment.ProductionEnvironment:
                             GotoUrl("https://abtassociates.service-now.com/navpage.do");
              //      Console.WriteLine("Service Now (Production) Home Page Took: " + LoadTime + " to load Using Simieo");
                //    Console.WriteLine("</br>");
                    SSOProvider = "Simieo";
                    portalEnvironment = "Production";
                    break;
                default:
                    break;
            }
        }

        private void GotoUrl(string url)
        {
                SeleniumDriver.Instance.Navigate().GoToUrl(url);
                StartTimer();
        }

        public void CloseITServiceRequest()
        {
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            AbtPages.TablePageObject.FirstRowItem.Click();
            ITSCResponder.SendKeys("Valeria Rozenbaum");
            TimeworkedOnIncident.Click();
            ITCategory.SelectOption("Software").Click();
            Thread.Sleep(1000);
            ITSubCategory.SelectOption("Application").Click();
            Thread.Sleep(1000);
            ITType.SelectOption("Upgrade").Click();
       
            IncidentComments.SendKeys("Incident Comments");
            ResolveIncident.Click();
        }

        public void CloseHRServiceRequest()
        {

            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            AbtPages.TablePageObject.FirstRowItem.Click();
             AssignToHRPerson.Clear();
            AssignToHRPerson.SendKeys("Michael Stinson");
            AdditionalComments.SendKeys("Additional Comments");
            HRworkNotes.SendKeys("Work notes");
            StatusDropdown.SelectOption("Resolved");
            Update.Click();

        }

      

        public bool OfficeRequestIsClosed(string shortdescription)
        {
          //  Driver.seleniumdriver.SwitchTo().Frame("gsft_main");
            LatestRequest = GetLatestRequest();
            IWebElement latestShortdescription = GetLatestShortdescription();

            if (!latestShortdescription.Text.Equals(shortdescription))
            {
                return true; 

            }


            return false;
            
        }


        public void GoTo(ServicenowLinks link)
        {
            switch (link)
            {
                case ServicenowLinks.ServiceHub:
                    SeleniumDriver.Instance.SwitchTo().Frame("gsft_nav");

                    SeleniumDriver.Instance.FindElement(By.LinkText("Home")).Click();
                    break;

                default:break;
            }
            
        }

        private string GetRoleText(IWebElement roleContainer)
        {
            //Get Text From the Label Element from the  List Element on the Nav Wrapper
            try
            {       
                return roleContainer.FindElements(By.TagName("label")).Where(e=>e.Text!=null).First().Text;
            }


            catch { Console.WriteLine("Could Not find Any Label element on List for Left Nav Panel"); return null; }

        }

        public void CloseOfficeRequest(string shortdescription,string worknotes,string assignedto)
        {
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");



                AbtPages.TablePageObject.FirstRowItem.Click();
                ReadyForWork.Click();
                Facility_AssigntoPerson.SendKeys(assignedto);
                timeworked.Click();
                FacilityWorknotes.SendKeys(worknotes);
                Update.Click();
            AbtPages.TablePageObject.FirstRowItem.Click();
            StartWork.Click();
            FacilityWorknotes.SendKeys("Work completed");
            closeComplete.Click();




        }

        private IWebElement OpenRequest()
        {
            IList<IWebElement> latestrequest = LatestRequest.FindElements(By.TagName("td"));
           return latestrequest[2];
        }

        private IWebElement GetLatestShortdescription()
        {
            return LatestRequest.FindElements(By.TagName("td"))[4];
        }

        private IWebElement GetLatestRequest()
        {
           return UnassignedFacilitiesTable.FindElements(By.TagName("tr"))[0];
        }

        private IEnumerable<IWebElement> GetRoleList()
        {
            //Get Lists From the Left Nav wrapper 
            try { return RoleList.FindElements(By.TagName("li")).Where(e=>e.GetAttribute("id")=="");}

            catch { Console.WriteLine("Could not Find Any List Element on Left Nav Panel"); return null; }
        }

        public void FillRoles()
        {
            rolesDictionary = new Dictionary<string, string[]>();
            rolesDictionary.Add("Valeria Rozenbaum", new string[] { "Abt Service Hub", "Self-Service", "Service Desk", "Incident", "Problem", "Change", "Time Card", "Configuration", "Service Catalog", "Knowledge", "Reports", "BSM Map" });
            rolesDictionary.Add("Jose Frometa", new string[] { "Abt Service Hub", "Self-Service" });
            rolesDictionary.Add("Michael Stinson", new string[] { "Abt Service Hub", "Self-Service","HR Service Center","Reports" });
            rolesDictionary.Add("Zanira Khan", new string[] { "Abt Service Hub", "Self-Service", "Service Desk","Incident","Problem","Change","Time Card","Configuration","Service Catalog","Reports","BSM Map","IT GRC"});
            rolesDictionary.Add("Steve Hunt", new string[] { "Abt Service Hub", "Self-Service", "Product Catalog", "Inventory","Facilities","Skills","Territories","Reports" });

        }

      

        public bool isCurrentUser(string user)
        {
            if (CurrentUser.Text.Equals(user))
            {
                return true;
            }

            return false;
        }

        public bool isUserLoggedIn()
        {
            if (CurrentUser.Text.Equals("Jose Frometa"))
            {
               
             //   Console.WriteLine("User: David succesfully logged in using "+SSOProvider);

                return true;
            }

            return false;
        }

        public void ImpersonateUser(string User)
        {
             UserIcon.Click();
             GetUser(User).Click();
             OkBtn.Click();

        }

        private IWebElement GetUser(string user)
        {
            try { return Users.FindElements(By.TagName("option")).Single(e => e.Text.Equals(user)); }

            catch(Exception e) { Console.WriteLine("Could not Find User " + user + " to Impersonate");
                return null;
                }
        }
    }
}