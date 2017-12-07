using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
using AbtFramework.Sikuli;
using AbtFramework.Sikuli.SikuliPatternObjects;
using AbtFramework.Sikuli.SikuliPatternObjects.OracleForms;
using Microsoft.Lync.Model.Conversation.Sharing;
using SikuliSharp;

namespace AbtFramework
{
    public class OraclePage : PageModel
    {
        static String gUser = "user";
        private OracleFormsPatternObject patterns;
        private CommonPaternObjects commonPatterns;
        private GradeRatePatternObject gradePatterns;
        private AbtHRMSManagerObject HRMSManagerPatterns;
        private ConfDefaultProcessRunsObjects ConfDefaultProcessRunsPatterns;
        private SikuliHelper sikuliHelper;
        private int counter = 11;
        private int counter1 = 8;

        [FindsBy(How = How.XPath, Using = "//*[@id='WF_SS_NOTIF_PAGE']/table[1]/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/table/tbody/tr/td[1]/a")]
        private IWebElement homeButton; //

        [FindsBy(How = How.Id, Using = "PageLayoutRN")]
        private IWebElement headerInfo; //

        [FindsBy(How = How.CssSelector, Using = "#PageLayoutRN > div > div:nth-child(5) > div > div.x63 > table > tbody > tr > td > h1")]
        private IWebElement OracleWelcome; //

        [FindsBy(How = How.XPath, Using = "//input[contains(@title,'User Name')]")]
        private IWebElement username;

        [FindsBy(How = How.XPath, Using = "//input[contains(@title,'Password')]")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[@title='Login']")]
        private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//h2[text()='Navigator']/ancestor::tr[2]/following-sibling::tr[2]/descendant::div[1]/child::div[2]/descendant::tr[1]/child::td[1]")]
        private IWebElement homeMenuTable;

        [FindsBy(How = How.XPath, Using = "//span[text()='Subject']/parent::th/parent::tr/following-sibling::tr[1]/child::td[1]/child::a")]
        private IWebElement timeCardToBeApproved;

        [FindsBy(How = How.XPath, Using = "//a[@title='Orders']/ancestor::table[2]/following-sibling::div/child::div[3]/child::div[1]/child::div[2]/descendant::button[@title='Approve']")]
        private IWebElement buttonApproveTimeCard;

        [FindsBy(How = How.XPath, Using = "//a[@title='Non-Catalog Request']")]
        private IWebElement nonCatalogRequest;

        [FindsBy(How = How.XPath, Using = "//a[text()='Time Entry']")]
        private IWebElement timeEntry;

        [FindsBy(How = How.XPath, Using = "//a[text()='Create Timecard']")]
        private IWebElement createTimecards;

        //    time ard creation variables
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Project')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[1]/descendant::input")]
        private IWebElement projectTimeCardInput;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[2]/descendant::input")]
        private IWebElement tasktTimeCardInput;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[3]/descendant::input")]
        private IWebElement typeTimeCardInput;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[4]/descendant::input")]
        private IWebElement timeInput1;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[5]/descendant::input")]
        private IWebElement timeInput2;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[6]/descendant::input")]
        private IWebElement timeInput3;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[7]/descendant::input")]
        private IWebElement timeInput4;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[8]/descendant::input")]
        private IWebElement timeInput5;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[9]/descendant::input")]
        private IWebElement timeInput6;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[10]/descendant::input")]
        private IWebElement timeInput7;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Time Entry')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Review, then Save']")]
        private IWebElement reviewThenSavebutton;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Confirmation:')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Return to Time Entry']")]
        private IWebElement returnToTimeEntryButtonTimeCard;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Time Entry:')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Begin Submit Process']")]
        private IWebElement timecardBeginSubmit;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Review:')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Submit']")]
        private IWebElement timecardSubmit;

        //         Browse Abt US Employee Direct Access  

        [FindsBy(How = How.XPath, Using = "//h2[text()='Navigator']/ancestor::tr[2]/following-sibling::tr[2]/descendant::div[1]/child::div[2]/descendant::tr[1]/child::td[2]")]
        private IWebElement userBrowsingOptions;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Review')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Save'][text()='Complete Save Process']")]
        private IWebElement completeSaveTimeCardProcess;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Item Description')]/parent::td/following-sibling::td[2]/child::textarea")]
        private IWebElement itemDescription;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Quantity')]/parent::td/following-sibling::td[2]/child::input")]
        private IWebElement quantity;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Unit of Measure')]/parent::td/following-sibling::td[2]/child::span/child::input")]
        private IWebElement unitOfMeasure;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Unit Price')]/parent::td/following-sibling::td[2]/child::input")]
        private IWebElement unitPrice;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Supplier Name')]/parent::td/following-sibling::td[2]/child::span/child::input")]
        private IWebElement supplierName;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Contact Name')]/parent::td/following-sibling::td[2]/child::input")]
        private IWebElement contactName;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Phone')]/parent::td/following-sibling::td[2]/child::input")]
        private IWebElement phone;

        [FindsBy(How = How.XPath, Using = "//span[text()='Phone']/ancestor::table[2]/parent::div/parent::div/following-sibling::div/child::table/descendant::button[text()='Add to Cart']")]
        private IWebElement addToCart;

        [FindsBy(How = How.XPath, Using = "//button[@title='Proceeds to the Shopping Cart page.'][contains(text(),'View Cart and Checkout')]")]
        private IWebElement viewCartAndCheckout;

        [FindsBy(How = How.XPath, Using = "//a[text()='Return to Shopping']/parent::td/following-sibling::td[1]/descendant::button[text()='Checkout']")]
        private IWebElement checkout_uixr;

        [FindsBy(How = How.XPath, Using = "//span[text()='Project']/parent::td/following-sibling::td[2]/child::span/child::input")]
        private IWebElement project;

        [FindsBy(How = How.XPath, Using = "//span[text()='Expenditure Type']/parent::td/following-sibling::td[2]/child::span/child::input")]
        private IWebElement expenditureType;

        [FindsBy(How = How.XPath, Using = "//span[text()='Task']/parent::td/following-sibling::td[2]/child::span/child::input")]
        private IWebElement task;

        [FindsBy(How = How.XPath, Using = "//span[text()='Expenditure Item Date']/parent::td/following-sibling::td[2]/child::input")]
        private IWebElement expenditureItemDate;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Checkout: Requisition Information']/ancestor::div[2]/following-sibling::div/child::table/descendant::button[@title='Next']")]
        private IWebElement nextButtons;

        [FindsBy(How = How.XPath, Using = "//button[@title='Manage Approvals']")]
        private IWebElement manageApprovals;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Approver')]/parent::td/following-sibling::td[2]/child::span/child::input")]
        private IWebElement newApproverText;

        [FindsBy(How = How.Id, Using = "SubmitButton_uixr")]
        private IWebElement submitButton_uixr; //

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add to Location')]/parent::td/following-sibling::td[2]/child::select")]
        private IWebElement approverLocation;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Checkout: Approvals and Notes']/ancestor::div[2]/following-sibling::div/child::table/descendant::button[@title='Next']")]
        private IWebElement ApprovalNextButton;

        [FindsBy(How = How.XPath, Using = "//button[text() = 'Continue Shopping']")]
        private IWebElement continueShoppingButton;

        [FindsBy(How = How.XPath, Using = "//span[text()='Buyer Work Center']/parent::td/parent::tr/following-sibling::tr[1]//a[text()='Requisitions']")]
        private IWebElement requisitionsBuyerWorkCenter;

        [FindsBy(How = How.XPath, Using = "//span[text()='Requisitions']/parent::td/parent::tr/following-sibling::tr[2]//a[text()='Requisitions']")]
        private IWebElement requisitionsRequisitions;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][@value='0']")]
        private IWebElement requisitionToBeAdded;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Select None')]/ancestor::tr[2]/preceding-sibling::tr[1]/descendant::button[@title='Add to Document Builder']")]
        private IWebElement addRequisitionButton;

        [FindsBy(How = How.XPath, Using = "//button[@title='Create']")]
        private IWebElement createButton;

        [FindsBy(How = How.XPath, Using = "//a[text()='People']")]
        private IWebElement people;

        [FindsBy(How = How.XPath, Using = "//span[text()='View : Histories']/parent::td/parent::tr/following-sibling::tr[4]/child::td[3]/a[text()='Entries']")]
        private IWebElement entries;

        [FindsBy(How = How.XPath, Using = "//span[text()='View : Histories']/parent::td/parent::tr/following-sibling::tr[3]/child::td[3]/a[text()='Salary']")]
        private IWebElement salary;

        [FindsBy(How = How.XPath, Using = "//span[text()='View : Histories']/parent::td/parent::tr/following-sibling::tr[4]/child::td[3]/a[text()='Salary']")]
        private IWebElement salaryB;

        [FindsBy(How = How.XPath, Using = "//span[text()='Flexfield : Descriptive']/parent::td/parent::tr/following-sibling::tr[2]/child::td[3]/a[text()='Values']")]
        private IWebElement values;

        [FindsBy(How = How.XPath, Using = "//span[text()='View : Histories']/parent::td/parent::tr/following-sibling::tr[2]/child::td[3]/a[text()='Absence']")]
        private IWebElement absence;

        [FindsBy(How = How.XPath, Using = "//span[text()='Payroll']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']")]
        private IWebElement descriptionPayroll;

        [FindsBy(How = How.XPath, Using = "//span[text()='Work Structures : Grade']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']")]
        private IWebElement descriptionGrade;

        [FindsBy(How = How.XPath, Using = "//span[text()='Work Structures : Job']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']")]
        private IWebElement descriptionJob;

        [FindsBy(How = How.XPath, Using = "//span[text()='Work Structures : Organization']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']")]
        private IWebElement descriptionOrganization;

        [FindsBy(How = How.XPath, Using = "//span[text()='Work Structures : Position']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']")]
        private IWebElement descriptionPosition;

        // 	Voluntary Disclosure of Veterans Status
        [FindsBy(How = How.XPath, Using = "//button[@title='Add']")]
        private IWebElement addBtn;

        [FindsBy(How = How.XPath, Using = "//button[@title='Update']")]
        private IWebElement updateBtn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Choose Your Veteran Status')]/parent::td/following-sibling::td[2]/child::span/child::a")]
        private IWebElement searchVeteranStatusBtn;

        [FindsBy(How = How.XPath, Using = "//input[@title='Search Term']")]
        private IWebElement searchVeteranStatusInputBox;

        [FindsBy(How = How.XPath, Using = "//button[text()='Go']")]
        private IWebElement goBtn;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][value='0']")]
        private IWebElement selectStatus1;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][value='1']")]
        private IWebElement selectStatus2;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][value='2']")]
        private IWebElement selectStatus3;

        [FindsBy(How = How.XPath, Using = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[1]/child::td[2]/child::a/img")]
        private IWebElement quickSelect1;

        [FindsBy(How = How.XPath, Using = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[2]/child::td[2]/child::a/img")]
        private IWebElement quickSelect2;

        [FindsBy(How = How.XPath, Using = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[3]/child::td[2]/child::a/img")]
        private IWebElement quickSelect3;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Search and Select: Choose Your Veteran Status']/ancestor::div[1]/following-sibling::div[1]//button[text()='Select']")]
        private IWebElement selectBtn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Enter Your Name')]/parent::td/following-sibling::td[2]/input")]
        private IWebElement enterYourName;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Enter Your Name')]/parent::td/parent::tr/following-sibling::tr/child::td[3]//child::input")]
        private IWebElement date;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Voluntary Disclosure of Veterans Status']/ancestor::div[1]/following-sibling::div[1]//button[@title='Apply']")]
        private IWebElement applyBtn;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Extra Information']/ancestor::div[1]/following-sibling::div//descendant::button[text()='Save For Later']")]
        private IWebElement saveForLater;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Extra Information']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtn;

        [FindsBy(How = How.XPath, Using = "//button[@title='Add']")]
        private IWebElement addAttachments;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']")]
        private IWebElement submitBtn;

        [FindsBy(How = How.XPath, Using = "//button[@title='Home']")]
        private IWebElement homeBtn;


        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Detail Active Employee')]/preceding-sibling::a//img")]
        private IWebElement detailActiveEmployeeOptn;

        [FindsBy(How = How.XPath, Using = "//img[@alt = 'Select to expand']")]
        private IList<IWebElement> selectToExpandIcons;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'javascript:discoOpen')]")]
        private IList<IWebElement> expandedOptionToClick;

        //Change timecard approver
        [FindsBy(How = How.XPath, Using = "//input[@title='Search Criteria']")]
        private IWebElement nameInputField;

        [FindsBy(How = How.XPath, Using = "//button[@title='Go']")]
        private IWebElement goButton;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select']")]
        private IWebElement selectName;

        [FindsBy(How = How.XPath, Using = "//img[@title='Action']")]
        private IWebElement actionIcon;

        [FindsBy(How = How.XPath, Using = "//span[text()='Effective Date']/parent::td/following-sibling::td[2]//descendant::input")]
        private IWebElement effectiveDate;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Timecard Approver and Supervisor: Effective Date Options']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Continue']")]
        private IWebElement continueButton;

        [FindsBy(How = How.XPath, Using = "//input[@title='Manager']")]
        private IWebElement supervisorName;

        [FindsBy(How = How.XPath, Using = "//span[text()='Timecard Approver']/parent::td/following-sibling::td[2]//input")]
        private IWebElement timecardApprover;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Timecard Approver and Supervisor: Change Manager']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtnValidateChangeManager;

        [FindsBy(How = How.XPath, Using = "//span[text()='Change Reason']/parent::td/following-sibling::td[2]//select")]
        private IWebElement changeReason;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Timecard Approver and Supervisor: Assignment']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtnValidateAssignment;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Timecard Approver and Supervisor: Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']")]
        private IWebElement submitChangeTimecardApproverSupervisor;

        //Change employee hours
        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Effective Date Options']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Continue']")]
        private IWebElement continueBtn;

        [FindsBy(How = How.XPath, Using = "//input[@title='Work Hours']")]
        private IWebElement workHoursInputField;

        [FindsBy(How = How.XPath, Using = "//span[text()='Assignment Category']/parent::td/following-sibling::td[2]//select")]
        private IWebElement assignmentCategory;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Work Schedule']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtnValidateWorkSchedule;

        [FindsBy(How = How.XPath, Using = "//button[@title='Propose Pay Change']")]
        private IWebElement proposePayChange;

        [FindsBy(How = How.XPath, Using = "//span[text()='Reason For Pay Change']/parent::td/following-sibling::td[2]//select")]
        private IWebElement reasonForPayChange;

        [FindsBy(How = How.XPath, Using = "//input[@title='Actual Pay Amount']")]
        private IWebElement actualPayAmount;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Pay Details']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Apply']")]
        private IWebElement applyButton;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Select A Pay Action']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtnValidatePayChangeProposal;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']")]
        private IWebElement submitChangeHours;

        //Approve changes of hours and timecard approver
        [FindsBy(How = How.XPath, Using = "//select[@title='Provides a series of worklist views available']")]
        private IWebElement openNotifications;

        [FindsBy(How = How.XPath, Using = "//button[@title='Launches some defined function']")]
        private IWebElement goNotifications;

        [FindsBy(How = How.XPath, Using = "//a[text()='Subject']/parent::th/parent::tr/following-sibling::tr[1]/child::td[4]/a")]
        private IWebElement subjectLink;


        public IWebElement SelectFolderNavigator(string option)
        {
            string xpath = "//a[text() = '" + option + "']";
            return SeleniumDriver.Instance.FindElement(By.XPath(xpath));
        }

        public void GoToOracleDev()
        {
            StartTimer();
            //since its a clean session we go to agi to make o
            SeleniumDriver.Instance.Navigate().GoToUrl("https://abterp2.coresys.com/OA_HTML/AppsLocalLogin.jsp");
        }

        public bool isAt()
        {
            //Thread.Sleep(2000);
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            try
            {
                AbtFramework.AutoIT.AutoITDriver.init();
                AbtFramework.AutoIT.AutoITDriver.AceptCertificate();
            }
            catch (NoAlertPresentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (wait.Until(e => OracleWelcome.Displayed))
            {
                StopTimer();
                return true;
            }
            else
            {
                return false;
            }
        }

        private string LoginUser(string user)
        {
            gUser = user;
            var u = "user";

            switch (gUser)
            {
                case "Sofiane Oumsalem":
                    return u = "oumsalems";
                case "Gail Berg":
                    return u = "BergG";
                case "Alex Gutierrez":
                    return u = "GutierrezA";
                case "Mauricio Poodts":
                    return u = "PoodtsM";
                case "Jorge Elguera":
                    return u = "ElgueraJ";
                case "Noel Samuel":
                    return u = "SamuelN";
                case "Marlene Kruck":
                    return u = "KruckM";
                case "Valerie Hennessey":
                    return u = "PCTEST01";
                case "Allison Jung":
                    return u = "Junga";
                case "John Adamowicz":
                    return u = "AdamowiczJ";
                case "Daniel Gunther":
                    return u = "GuntherD";
                case "Lisa Butterfield":
                    return u = "HRTEST01";
                case "Phyllis Wallace":
                    return u = "WallaceP";
            }

            return u;
        }
        private IWebElement getLinkFromMainMenuTable(string link)
        {
            IWebElement element = null;
            Console.WriteLine(gUser);
            // structure to the text -> table/tbody/tr[index]/td[4]/a
            if (gUser.Equals("Valerie Hennessey"))
            {
                ICollection<IWebElement> rows = homeMenuTable.FindElements(By.TagName("tr"));
                try
                {
                    foreach (var row in rows)
                    {
                        element = row.FindElement(By.XPath("td[4]/a"));
                        if (element.GetAttribute("textContent").Equals(link))
                        {
                            return element;
                        }
                    }
                }
                catch (NoSuchElementException)
                {
                    //couldnot find 
                }
            }
            else
            {
                ICollection<IWebElement> rows = homeMenuTable.FindElements(By.TagName("tr"));

                try
                {
                    foreach (var row in rows)
                    {
                        element = row.FindElement(By.XPath("td[4]/a"));
                        if (element.GetAttribute("textContent").Equals(link))
                        {
                            return element;
                        }
                    }
                }
                catch (NoSuchElementException)
                {
                    //couldnot find 
                }
            }

            return element;
        }

        private IWebElement getLinkFromUserOptions(string link)
        {
            IWebElement element = null;
            Console.WriteLine(gUser);

            ICollection<IWebElement> rows = userBrowsingOptions.FindElements(By.TagName("tr"));

            try
            {
                foreach (var row in rows)
                {
                    if (row.GetAttribute("textContent").Equals(link))
                    {
                        element = row.FindElement(By.XPath("td[3]/a"));
                        return element;
                    }
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("could not find: " + link);
            }


            return element;
        }
        public void ClickMainMenuTableOption(string option)
        {
            Thread.Sleep(1000);
            SelectFolderNavigator(option).Click();
        }

        public void ClickRightSideMenuTableOptions(string option)
        {
            Thread.Sleep(1000);
            SelectFolderNavigator(option).Click();
            Thread.Sleep(1000);
            SeleniumDriver.Instance.Navigate().Back();

        }

        public void ClickUserOptions(string option)
        {
            Thread.Sleep(1000);
            IWebElement test = getLinkFromUserOptions(option);
            test.Click();
            Thread.Sleep(1000);
            SeleniumDriver.Instance.Navigate().Back();
        }

        public void ClickUserOptions1(string option)
        {
            Thread.Sleep(1000);
            IWebElement test = getLinkFromUserOptions(option);
            test.Click();
        }

        public void ClickHomeButton()
        {
            homeButton.Click();
        }
        private string GetCurrentUser()
        {
            return headerInfo.FindElement(By.TagName("div")).FindElements(By.TagName("table"))[0].FindElements(By.TagName("span"))[1].Text;
        }
        private IWebElement getHeader()
        {
            return headerInfo.FindElements(By.TagName("h1")).Single(e => e.Text.Equals("Oracle Applications Home Page"));
        }
        private IWebElement getHomeScreenRow(string option)
        {
            return headerInfo.FindElements(By.TagName("h1")).Single(e => e.Text.Equals(option));
        }
        public void inputUserName(String user)
        {

            username.SendKeys(LoginUser(user));
        }
        public void inputPasswordField(string user)
        {
            password.Clear();
            password.SendKeys("test123456");
        }
        public void clickSubmitButton()
        {
            loginButton.Click();
        }
        public void clickIProcurementRequest()
        {
            Thread.Sleep(1000);
            nonCatalogRequest.Click();
        }
        public void clickTimeCard()
        {
            timeEntry.Click();
            Thread.Sleep(1000);
            createTimecards.Click();
        }
        public void fillTimeCard()
        {
            projectTimeCardInput.SendKeys("10000 \r");
            tasktTimeCardInput.Click();
            Thread.Sleep(1000);
            tasktTimeCardInput.SendKeys("1011 \r");
            typeTimeCardInput.Click();
            Thread.Sleep(1000);
            typeTimeCardInput.SendKeys("Vacation");
            timeInput1.Click();
            Thread.Sleep(1000);
            timeInput1.SendKeys("0");
            timeInput2.SendKeys("0");
            timeInput3.SendKeys("8");
            timeInput4.SendKeys("8");
            timeInput5.SendKeys("8");
            timeInput6.SendKeys("8");
            timeInput7.SendKeys("8");
            Thread.Sleep(1000);
            reviewThenSavebutton.Click();
        }
        public void completeTimeCardRequest()
        {
            completeSaveTimeCardProcess.Click();
            Thread.Sleep(1000);
            returnToTimeEntryButtonTimeCard.Click();
            Thread.Sleep(1000);
            timecardBeginSubmit.Click();
            Thread.Sleep(1000);
            timecardSubmit.Click();
        }
        public void SelectAndApproveOrder()
        {
            timeCardToBeApproved.Click();
            Thread.Sleep(500);
            buttonApproveTimeCard.Click();
        }
        public void fillNonCatalogRequestForm()
        {
            Thread.Sleep(2000);
            itemDescription.SendKeys("Test Description");
            quantity.SendKeys("160");
            unitOfMeasure.SendKeys("Hour");
            unitPrice.Click();
            Thread.Sleep(5000);
            unitPrice.SendKeys("20");
            supplierName.SendKeys("Think Forward Consulting");
            contactName.Click();
            Thread.Sleep(5000);
            contactName.SendKeys("Test Contant Name");
            phone.Click();
            phone.SendKeys("8099880000");
            Thread.Sleep(1000);
            addToCart.Click();
            Thread.Sleep(2000);
            viewCartAndCheckout.Click();
        }
        public void clickCheckOut()
        {
            checkout_uixr.Click();
        }
        public void fillRequisitionInformation()
        {
            Thread.Sleep(3000);
            project.SendKeys("21553");
            task.Click();
            Thread.Sleep(5000);
            task.SendKeys("1100");
            expenditureType.Click();
            Thread.Sleep(2000);
            expenditureType.SendKeys("Misc Professional Sv");
            expenditureItemDate.Click();
            Thread.Sleep(2000);
            //Console.WriteLine(DateTime.Today.ToString("dd-MMMM-yyyy"));
            expenditureItemDate.SendKeys(string.Format("{0:dd-MMM-yyyy}", DateTime.Today));
            nextButtons.Click();
        }
        public void clickManageGraphButton()
        {
            manageApprovals.Click();
        }
        public void addBeforeApproverAndSubmit(string approver)
        {
            newApproverText.SendKeys(approver);

            SelectElement selector = new SelectElement(approverLocation);
            selector.SelectByText("Before Requisition Approver Controller");

            submitButton_uixr.Click();
        }
        public void addAfterApprover(string approver)
        {
            manageApprovals.Click();
            newApproverText.SendKeys(approver);

            SelectElement selector = new SelectElement(approverLocation);
            selector.SelectByText("After Requisition Approver Controller");
            submitButton_uixr.Click();
            Thread.Sleep(1000);
        }
        public void SubmitAfterApprovers()
        {
            ApprovalNextButton.Click();
        }

        public void submitApproval()
        {
            submitButton_uixr.Click();
            continueShoppingButton.Click();
        }

        public void openRequisitionsBuyerWorkCenter()
        {
            requisitionsBuyerWorkCenter.Click();
        }

        public void openRequisitionsRequisitions()
        {
            requisitionsRequisitions.Click();
        }

        public void selectRequisitionToBeAdded()
        {
            Thread.Sleep(2000);
            requisitionToBeAdded.Click();
        }

        public void addRequisition()
        {
            addRequisitionButton.Click();
        }

        public void clickCreate()
        {
            createButton.Click();
        }

        public void clickPeople()
        {
            people.Click();
        }

        public void clickEntries()
        {
            entries.Click();
        }

        public void clickSalary()
        {
            salary.Click();
        }

        public void clickSalaryB()
        {
            salaryB.Click();
        }

        public void clickValues()
        {
            values.Click();
        }

        public void clickAbsence()
        {
            absence.Click();
        }

        public void clickDescriptionPayroll()
        {
            descriptionPayroll.Click();
        }

        public void clickDescriptionGrade()
        {
            descriptionGrade.Click();
        }

        public void clickDescriptionJob()
        {
            descriptionJob.Click();
        }

        public void clickDescriptionOrganization()
        {
            descriptionOrganization.Click();
        }

        public void clickDescriptionPosition()
        {
            descriptionPosition.Click();
        }

        public const string MyAccountPageTitle = "My Account";

        public static bool IsAt()
        {
            return SeleniumDriver.Instance.Title == "Search";
        }


        public void chooseVeteranStatus()
        {
            updateBtn.Click();
            searchVeteranStatusBtn.Click();
            Thread.Sleep(1000);
            // Store all the opened window into the 'list' 
            List<string> lstWindow = SeleniumDriver.Instance.WindowHandles.ToList();
            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[1]);
            SeleniumDriver.Instance.SwitchTo().Frame(0);
            searchVeteranStatusInputBox.Clear();
            goBtn.Click();
            Thread.Sleep(1000);
            quickSelect2.Click();
            List<string> lstWindow1 = SeleniumDriver.Instance.WindowHandles.ToList();
            SeleniumDriver.Instance.SwitchTo().Window(lstWindow1[0]);
            date.Clear();
            date.SendKeys(string.Format("{0:dd-MMM-yyyy}", DateTime.Today));
            applyBtn.Click();
            nextBtn.Click();
            submitBtn.Click();
            homeBtn.Click();

        }

        public void DoDiscovererWorkbookMultipleSheets()
        {
            Thread.Sleep(2000);
            detailActiveEmployeeOptn.Click();
            ClickMainMenuTableOption("Modified Detail Active Emp Listing");

        }

        public void DoDiscovererWorkbookOneSheet()
        {
            int count = 0;
            Thread.Sleep(1000);
            //to expand all menus first
            while (selectToExpandIcons.Count != 0)
            {
                selectToExpandIcons[0].Click();
                Thread.Sleep(1000);
                selectToExpandIcons = SeleniumDriver.Instance.FindElements(By.XPath("//img[@alt = 'Select to expand']"));

            }

            //to click on the expanded links
            while (count < expandedOptionToClick.Count)
            {
                expandedOptionToClick[count].Click();
                Thread.Sleep(1000);
                count++;
            }

        }

        /// <summary>
        /// Accepts Java alerts to run Oracle application
        /// </summary>
        private void AcceptJavaAlert()
        {
            patterns = new OracleFormsPatternObject();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            //there is another alert, verify if present or not
            if (commonPatterns.GetAcceptCheckBoxSecurityWarning != null)
            {
                sikuliHelper.ClickPattern(commonPatterns.GetAcceptCheckBoxSecurityWarning);
                sikuliHelper.ClickPattern(commonPatterns.GetRunOracleSecurityWarning);
            }

            //sometimes it shows twice
            if (commonPatterns.GetRunOracleBtn != null)
                sikuliHelper.ClickPattern(commonPatterns.GetRunOracleBtn);

            if (commonPatterns.GetRunOracleBtn != null)
                sikuliHelper.ClickPattern(commonPatterns.GetRunOracleBtn);


        }

        public void FillOracleFroms()
        {

            patterns = new OracleFormsPatternObject();
            commonPatterns = new CommonPaternObjects();

            AcceptJavaAlert();

            sikuliHelper.SetInputValue(patterns.GetDescriptionInput1, "test");

            sikuliHelper.ClickPattern(patterns.GetNum);

            sikuliHelper.ClickPattern(patterns.GetType);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectGoods);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetCategory);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn2);

            sikuliHelper.ClickPattern(patterns.GetSelectFunding);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn3);

            sikuliHelper.ClickPattern(patterns.GetSelectIncrease);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn2);

            sikuliHelper.SetInputValue(patterns.GetDescriptionInput2, "test");

            sikuliHelper.ClickPattern(patterns.GetUOM);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn4);

            sikuliHelper.ClickPattern(patterns.GetSelectEach);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.SetInputValue(patterns.GetQuantity, "100");

            while (counter > 0)
            {
                sikuliHelper.ClickPattern(patterns.GetRightArrow);
                counter--;
            }

            sikuliHelper.SetInputValue(patterns.GetPrice, "50");

            sikuliHelper.ClickPattern(patterns.GetNeedBy);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectDate);

            sikuliHelper.ClickPattern(patterns.GetOkBtn3);

            sikuliHelper.ClickPattern(patterns.GetOrganization);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectOrganization);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetLocation);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.SetInputValue(patterns.GetFindLocation, "bethesda");

            sikuliHelper.ClickPattern(patterns.GetFindBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetDistributions);

            sikuliHelper.ClickPattern(patterns.GetProjectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.SetInputValue(patterns.GetFindLocation, "21553");

            sikuliHelper.ClickPattern(patterns.GetFindBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.SetInputValue(patterns.GetFindLocation, "1100");

            sikuliHelper.ClickPattern(patterns.GetFindBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.SetInputValue(patterns.GetFind2, "misc");

            sikuliHelper.ClickPattern(patterns.GetFindBtn);

            sikuliHelper.ClickPattern(patterns.GetProjectType);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetDate);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectDate);

            sikuliHelper.ClickPattern(patterns.GetOkBtn3);

            sikuliHelper.ClickPattern(patterns.GetSaveIcon);

            sikuliHelper.ClickPattern(patterns.GetCloseWindow);

            sikuliHelper.ClickPattern(patterns.GetApproveBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn4);

        }

        public void FillTheGradeRateOracleForms()
        {

            gradePatterns = new GradeRatePatternObject();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(gradePatterns.GetNoBtn);

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetEnter);

            sikuliHelper.SetInputValue(gradePatterns.GetNameField, "%");

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetRun);

            sikuliHelper.ClickPattern(gradePatterns.GetGradeNameField);

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetEnter);

            sikuliHelper.SetInputValue(gradePatterns.GetGradeNameInputField, "%Can%");

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetRun);

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetEnter);

            sikuliHelper.SetInputValue(gradePatterns.GetGradeNameInputField, "%Mex%");

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetRun);
        }

        public void UpdateInformationOnOracleForm()
        {
            HRMSManagerPatterns = new AbtHRMSManagerObject();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetNoBtn);

            sikuliHelper.SetInputValue(HRMSManagerPatterns.GetFullName, "oumsalem");

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetFindBtn);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetOfficeDetails);

            sikuliHelper.SetInputValue(HRMSManagerPatterns.GetOfficeInputField, "test");

            sikuliHelper.PressEnter();

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetCorrectionBtn);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetSaveIcon);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetCloseOracleForm);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetOkBtn);

        }

        public void GoToOracleForm()
        {
            HRMSManagerPatterns = new AbtHRMSManagerObject();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetNoBtn);

            sikuliHelper.SetInputValue(HRMSManagerPatterns.GetFullName, "oumsalem");

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetFindBtn);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetCloseOracleForm);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetOkBtn);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetCloseWindow);
        }

        public void ChangeTimecardApprover()
        {
            nameInputField.SendKeys("laidoson");
            goButton.Click();
            selectName.Click();
            actionIcon.Click();
            effectiveDate.SendKeys("09-Dec-2017");
            continueButton.Click();
            supervisorName.Clear();
            supervisorName.SendKeys("poodts"); 
            supervisorName.SendKeys(Keys.Tab);
            nextBtnValidateChangeManager.Click();
            timecardApprover.Clear();
            timecardApprover.SendKeys("poodts");
            timecardApprover.SendKeys(Keys.Tab);
            Thread.Sleep(1000);
            SelectElement select = new SelectElement(changeReason);
            select.SelectByText("Supervisor & Timecard Approver Change");
            nextBtnValidateAssignment.Click();
            submitChangeTimecardApproverSupervisor.Click();
            homeBtn.Click();
        }

        public void ChangeEmployeeHours()
        {
            nameInputField.SendKeys("laidoson");
            goButton.Click();
            selectName.Click();
            actionIcon.Click();
            effectiveDate.SendKeys("09-Dec-2017");
            continueBtn.Click();
            workHoursInputField.Clear();
            workHoursInputField.SendKeys("32");
            Thread.Sleep(1000);
            SelectElement select = new SelectElement(assignmentCategory);
            select.SelectByText("Parttime-Standard");
            nextBtnValidateWorkSchedule.Click();
            proposePayChange.Click();
            Thread.Sleep(1000);
            SelectElement selectReason = new SelectElement(reasonForPayChange);
            selectReason.SelectByText("Status Change");
            actualPayAmount.SendKeys("50000");
            applyButton.Click();         
            applyButton.Click();           
            nextBtnValidatePayChangeProposal.Click();
            submitChangeHours.Click();
        }

        public void ApproveChanges()
        {
            SelectElement select = new SelectElement(openNotifications);
            select.DeselectByText("All Notifications");
            goNotifications.Click();
            subjectLink.Click();
        }

        public void ConfirmDefaultProcess()
        {
            ConfDefaultProcessRunsPatterns = new ConfDefaultProcessRunsObjects();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetNoBtn);

            sikuliHelper.SetInputValue(ConfDefaultProcessRunsPatterns.GetFullName, "oumsalem");

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetFindBtn);

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetName);

            while (counter1 > 0)
            {
                sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetDownArrow);
                counter1--;
            }

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetNewHire); 

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetDesktopActivities); 

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetEnrollmentResults);

        }
    }
}