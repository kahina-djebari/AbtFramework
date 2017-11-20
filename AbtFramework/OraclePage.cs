using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AbtFramework.Sikuli;
using AbtFramework.Sikuli.SikuliPatternObjects.OracleForms;
using SikuliSharp;

namespace AbtFramework
{
    public class OraclePage : PageModel
    {
        static String gUser = "user";

        private int counter = 11;

        private int counter1 = 21;

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

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Choose Your Veteran Status')]/parent::td/following-sibling::td[2]/child::span/child::a")]
        private IWebElement searchVeteranStatusBtn;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Go')]")]
        private IWebElement goBtn;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][value='0']")]
        private IWebElement selectBtn1;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][value='1']")]
        private IWebElement selectBtn2;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][value='2']")]
        private IWebElement selectBtn3;

        [FindsBy(How = How.XPath, Using = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[1]/child::td[2]/child::a/img")]
        private IWebElement quickSelectBtn1;

        [FindsBy(How = How.XPath, Using = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[2]/child::td[2]/child::a/img")]
        private IWebElement quickSelectBtn2;

        [FindsBy(How = How.XPath, Using = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[3]/child::td[2]/child::a/img")]
        private IWebElement quickSelectBtn3;



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


        public void FillOracleFroms()
        {     

        OracleFormsPatternObject patterns = new OracleFormsPatternObject();
            SikuliHelper.GetInstance().ClickPattern(patterns.GetRunOracleBtn);
        
            if(SikuliHelper.GetInstance().IsPatternExisting(patterns.GetRunOracleBtn))
                SikuliHelper.GetInstance().ClickPattern(patterns.GetRunOracleBtn);

            SikuliHelper.GetInstance().SetInputValue(patterns.GetDescriptionInput1, "test");

            SikuliHelper.GetInstance().ClickPattern(patterns.GetNum);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetType);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectBtn);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectGoods);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetOkBtn);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetCategory);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectBtn);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectBtn2);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectFunding);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetOkBtn);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectBtn3);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectIncrease);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetOkBtn);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetOkBtn2);

            SikuliHelper.GetInstance().SetInputValue(patterns.GetDescriptionInput2, "test");

            SikuliHelper.GetInstance().ClickPattern(patterns.GetUOM);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectBtn4);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectEach);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetOkBtn);
       
            SikuliHelper.GetInstance().SetInputValue(patterns.GetQuantity, "100");
          
            while (counter > 0)
            {
                SikuliHelper.GetInstance().ClickPattern(patterns.GetRightArrow);
                counter--;              
            }

            SikuliHelper.GetInstance().SetInputValue(patterns.GetPrice, "50");

            SikuliHelper.GetInstance().ClickPattern(patterns.GetNeedBy);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectBtn);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectDate);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetOkBtn2);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetOrganization);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectBtn);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectOrganization);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetOkBtn);

            SikuliHelper.GetInstance().ClickPattern(patterns.GetSelectBtn);



            while (counter1 > 0)
            {
                SikuliHelper.GetInstance().ClickPattern(patterns.GetRightArrow);
                counter1--;
            }

         

        }

    }
}