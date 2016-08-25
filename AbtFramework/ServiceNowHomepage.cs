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

        [FindsBy(How=How.Id,Using = "impersonate_span")]
        private IWebElement UserIcon;

        [FindsBy(How = How.Id, Using = "imp_recent")]
        private IWebElement Users;

        [FindsBy(How=How.Id,Using = "gsft_full_name")]
        private IWebElement CurrentUser;

        [FindsBy(How = How.ClassName, Using = "nav-wrapper")]
        private IWebElement RoleList;

        [FindsBy(How=How.LinkText,Using ="Home")]
        private IWebElement ServiceHub;

        private Dictionary<string,string[]> rolesDictionary;

        [FindsBy(How=How.ClassName,Using = "list2_body")]
        private IWebElement UnassignedFacilitiesTable;

        private IWebElement LatestRequest;
        [FindsBy(How=How.Id,Using = "link.facilities_request.time_worked")]
        private IWebElement timeworked;

        [FindsBy(How=How.Id,Using = "readyForWork")]
        private IWebElement ReadyForWork;

        [FindsBy(How=How.Id,Using = "facilities_request.work_notes")]
        private IWebElement workNotes;
        [FindsBy(How=How.Id,Using = "sysverb_update")]
        private IWebElement Update;
        [FindsBy(How=How.Id,Using = "sys_display.facilities_request.assigned_to")]
        private IWebElement AssignTo_OfficePerson;

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

        public bool isRoleCorrect(string user)
        {
            Driver.seleniumdriver.SwitchTo().Frame("gsft_nav");
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

        public void CloseITServiceRequest()
        {
            Driver.seleniumdriver.SwitchTo().Frame(Driver.seleniumdriver.FindElement(By.Id("gsft_nav"))); 
            myGroupsWorkLink.Click();
            Driver.seleniumdriver.SwitchTo().ParentFrame();
            Driver.seleniumdriver.SwitchTo().Frame(Driver.seleniumdriver.FindElement(By.Id("gsft_main")));
           LatestRequest = GetLatestRequest();
            OpenRequest().Click();
            ITSCResponder.SendKeys("Valeria Rozenbaum");
            TimeworkedOnIncident.Click();
            ITCategory.SendKeys("Software");
            ITSubCategory.SendKeys("Application");
            ITType.SendKeys("Failure");
            IncidentComments.SendKeys("Incident Comments");
            ResolveIncident.Click();

        }

    

   

        public void CloseHRServiceRequest()
        {
          

            Driver.seleniumdriver.SwitchTo().Frame("gsft_main");
            OrderByCreated.Click();
            Thread.Sleep(1000);
            UnassignedFacilitiesTable.FindElements(By.TagName("tr"))[0].FindElements(By.TagName("td"))[2].Click();
             AssignToHRPerson.Clear();
            AssignToHRPerson.SendKeys("Michael Stinson");
            AdditionalComments.SendKeys("Additional Comments");
            HRworkNotes.SendKeys("Work notes");
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

        public void Goto(ServicenowLinks link)
        {
            switch (link)
            {
                case ServicenowLinks.ServiceHub:
                    Driver.seleniumdriver.SwitchTo().Frame("gsft_nav");
                    ServiceHub.Click();
                    break;
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
            Driver.seleniumdriver.SwitchTo().Frame("gsft_main");
           

            LatestRequest=  GetLatestRequest();
            IWebElement latestShortdescription = GetLatestShortdescription();
         
            if (latestShortdescription.Text.Equals(shortdescription))
            {
                OpenRequest().Click();
                ReadyForWork.Click();
                AssignTo_OfficePerson.SendKeys(assignedto);
                timeworked.Click();
                workNotes.SendKeys(worknotes);
                Update.Click();

                               
            }

            else
            {
                Console.WriteLine("Can't find Office Request  with short description: " + shortdescription);
            }
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
            rolesDictionary.Add("David Acuna", new string[] { "Abt Service Hub", "Self-Service" });
            rolesDictionary.Add("Michael Stinson", new string[] { "Abt Service Hub", "Self-Service","HR Service Center","Reports" });
            rolesDictionary.Add("Zanira Khan", new string[] { "Abt Service Hub", "Self-Service", "Service Desk","Incident","Problem","Change","Time Card","Configuration","Service Catalog","Reports","BSM Map","IT GRC"});
            rolesDictionary.Add("Steve Hunt", new string[] { "Abt Service Hub", "Self-Service", "Product Catalog", "Inventory","Facilities","Skills","Territories","Reports" });

        }

        public void Go()
        {
            Driver.seleniumdriver.Navigate().GoToUrl("https://abtassoctest.service-now.com/navpage.do");
        }

        public bool isCurrentUser(string user)
        {
            if (CurrentUser.Text.Equals(user))
            {
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