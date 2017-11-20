using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{

    public class OraclePage : PageModel
    {
        //WE ROCK
        static String gUser = "user";

        [FindsBy(How = How.XPath, Using = "//*[@id='WF_SS_NOTIF_PAGE']/table[1]/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/table/tbody/tr/td[1]/a")]
        private IWebElement homeButton;

        [FindsBy(How = How.Id, Using = "PageLayoutRN")]
        private IWebElement headerInfo;

        [FindsBy(How = How.CssSelector, Using = "#PageLayoutRN > div > div:nth-child(5) > div > div.x63 > table > tbody > tr > td > h1")]
        private IWebElement OracleWelcome;

        [FindsBy(How = How.XPath, Using = "//input[contains(@title,'User Name')]")]
        private IWebElement username;

        [FindsBy(How = How.XPath, Using = "//input[contains(@title,'Password')]")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[contains(@title,'Login')]")]
        private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='region1']/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[1]/table/tbody")]
        private IWebElement homeMenuTableValerie;

        [FindsBy(How = How.XPath, Using = "//*[@id='region1']/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[1]/table/tbody")]
        private IWebElement homeMenuTable;

        [FindsBy(How = How.XPath, Using = "//*[@id='region1']/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[1]/table/tbody/tr[2]/td[4]/a")]
        private IWebElement iProcurementRequest;

        [FindsBy(How = How.XPath, Using = "//*[@id='region1']/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[1]/table/tbody/tr[4]/td[4]/a")]
        private IWebElement abtTimeCard;
        [FindsBy(How = How.XPath, Using = "//*[@id='region1']/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[1]/table/tbody/tr[2]/td[4]/a")]
        private IWebElement iProcurementInquiry;
        [FindsBy(How = How.Id, Using = "N41:NtfSubject:0")]
        private IWebElement timeCardToBeApproved;
        [FindsBy(How = How.XPath, Using = "//*[@id='rowLayout']/td[2]/button")]
        private IWebElement buttonApproveTimeCard;
        [FindsBy(How = How.Id, Using = "ICXPOR_NONCATALOG")]
        private IWebElement nonCatalogRequest;
        [FindsBy(How = How.Id, Using = "N55")]
        private IWebElement timeEntry;
        [FindsBy(How = How.Id, Using = "HXC_TIMECARD_DIRECT")]
        private IWebElement createTimecards;
        //    time ard creation variables
        [FindsBy(How = How.Id, Using = "A241N1display")]
        private IWebElement projectTimeCardInput;
        [FindsBy(How = How.Id, Using = "A251N1display")]
        private IWebElement tasktTimeCardInput;
        [FindsBy(How = How.Id, Using = "A261N1display")]
        private IWebElement typeTimeCardInput;
        [FindsBy(How = How.Id, Using = "B22_1_0")]
        private IWebElement timeInput1;
        [FindsBy(How = How.Id, Using = "B22_1_1")]
        private IWebElement timeInput2;
        [FindsBy(How = How.Id, Using = "B22_1_2")]
        private IWebElement timeInput3;
        [FindsBy(How = How.Id, Using = "B22_1_3")]
        private IWebElement timeInput4;
        [FindsBy(How = How.Id, Using = "B22_1_4")]
        private IWebElement timeInput5;
        [FindsBy(How = How.Id, Using = "B22_1_5")]
        private IWebElement timeInput6;
        [FindsBy(How = How.Id, Using = "B22_1_6")]
        private IWebElement timeInput7;
        [FindsBy(How = How.Id, Using = "Hxcsavebutton")]
        private IWebElement reviewThenSavebutton;
        [FindsBy(How = How.Id, Using = "HxcTcReturnButton")]
        private IWebElement returnToTimeEntryButtonTimeCard;
        [FindsBy(How = How.Id, Using = "Hxcnextbutton")]
        private IWebElement timecardBeginSubmit;
        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement timecardSubmit;
        //
        //         Browse Abt US Employee Direct Access  
        ////                                 *[@id="region1"]/tbody/tr[4]/td/table/tbody/tr/td/div/div[3]/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]
        //                                   *[@id="region1"]/tbody/tr[4]/td/table/tbody/tr/td/div/div[3]/table/tbody/tr/td[2]/table/tbody
        [FindsBy(How = How.XPath, Using = "//*[@id='region1']/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[2]/table/tbody")]
        private IWebElement userBrowsingOptions;
        // 
        [FindsBy(How = How.Id, Using = "Hxccuitcsaveforlater")]
        private IWebElement completeSaveTimeCardProcess;
        [FindsBy(How = How.Id, Using = "ItemDescription")]
        private IWebElement itemDescription;
        [FindsBy(How = How.Id, Using = "Quantity")]
        private IWebElement quantity;
        [FindsBy(How = How.Id, Using = "UnitOfMeasureTl")]
        private IWebElement unitOfMeasureTl;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement unitPrice;
        [FindsBy(How = How.Id, Using = "SupplierOnNonCat")]
        private IWebElement supplierOnNonCat;
        [FindsBy(How = How.Id, Using = "SupplierContact")]
        private IWebElement supplierContact;
        [FindsBy(How = How.Id, Using = "SupplierContactPhone")]
        private IWebElement supplierContactPhone;
        [FindsBy(How = How.Id, Using = "AddToCart_uixr")]
        private IWebElement addToCart;
        [FindsBy(How = How.Id, Using = "Checkout")]
        private IWebElement checkout;
        [FindsBy(How = How.Id, Using = "Checkout_uixr")]
        private IWebElement checkout_uixr;
        [FindsBy(How = How.Id, Using = "ProjectOnSummaryExpense")]
        private IWebElement projectOnSummaryExpense;
        [FindsBy(How = How.Id, Using = "ExpenditureTypeOnSummary")]
        private IWebElement expenditureTypeOnSummary;
        [FindsBy(How = How.Id, Using = "TaskExpense")]
        private IWebElement taskExpense;
        [FindsBy(How = How.Id, Using = "ExpenditureItemDate")]
        private IWebElement expenditureItemDate;
        [FindsBy(How = How.XPath, Using = "//*[@id='PageButtonsRN_uixr']/tbody/tr/td[12]/button")]
        private IWebElement nextButtons;
        [FindsBy(How = How.Id, Using = "ManageGraphButton")]
        private IWebElement manageGraphButton;
        [FindsBy(How = How.Id, Using = "NewApproverText")]
        private IWebElement newApproverText;
        [FindsBy(How = How.Id, Using = "SubmitButton_uixr")]
        private IWebElement submitButton_uixr;
        [FindsBy(How = How.Id, Using = "ApproverLocation")]
        private IWebElement approverLocation;
        [FindsBy(How = How.XPath, Using = "//*[@id='PageActionButtonsBar_uixr']/tbody/tr/td[10]/button")]
        private IWebElement ApprovalNextButton;
        [FindsBy(How = How.XPath, Using = "//button[text() = 'Continue Shopping']")]
        private IWebElement continueShoppingButton;


        public IWebElement SelectFolderNavigator(string option)
        {
            string xpath = "//a[text() = '" + option + "']";
            return SeleniumDriver.DriverInstance.FindElement(By.XPath(xpath));
        }

        public IWebElement SetUserName()
        {
            string xpath = "//input[contains(@title,'User Name')]";
            return SeleniumDriver.GetElementByXpath(xpath);
        }



        public void GoToOracleDev()
        {
            StartTimer();
            //since its a clean session we go to agi to make o
            SeleniumDriver.DriverInstance.Navigate().GoToUrl("http://ows2.cam.abtassoc.com:8004/OA_HTML/RF.jsp?function_id=24317&resp_id=-1&resp_appl_id=-1&security_group_id=0&lang_code=US&params=zuyf3HSa5SE5TW4skJCoR.tQktlyFm-Wf-QTiw1Fiis&oas=Jb1csHEd2rPR7y1fXeYcFA..");

        }


        public bool isAt()
        {
            //Thread.Sleep(2000);
            SeleniumDriver.DriverInstance.SwitchTo().Window(SeleniumDriver.DriverInstance.WindowHandles.Last());
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
                ICollection<IWebElement> rows = homeMenuTableValerie.FindElements(By.TagName("tr"));

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
            //*[@id="region1"]/tbody/tr[4]/td/table/tbody/tr/td/div/div[3]/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]
            //*[@id="region1"]/tbody/tr[4]/td/table/tbody/tr/td/div/div[3]/table/tbody/tr/td[2]/table/tbody/tr[4]/td[3]
            //*[@id="N43"]

            //*[@id="region1"]/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[2]/table/tbody
            try
            {
                foreach (var row in rows)
                {
                    ////*[@id="region1"]/tbody/tr[4]/td/table/tbody/tr/td/div/div[3]/table/tbody/tr/td[2]/table/tbody/tr[12]/td[3]
                    //element = row.FindElement(By.XPath("a"));
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
            //IWebElement test = getLinkFromMainMenuTable(option);
            SelectFolderNavigator(option).Click();
            // test.Click();        
        }
        public void ClickUserOptions(string option)
        {
            Thread.Sleep(1000);
            IWebElement test = getLinkFromUserOptions(option);
            test.Click();
            Thread.Sleep(1000);
            SeleniumDriver.DriverInstance.Navigate().Back();
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
            //APILauncher laun = new APILauncher(true);
            //Screen screen = new Screen();
            //Pattern patt = new Pattern("C:/Users/bernhardtj/Pictures/calculatorBtn.PNG");

            //screen.Wait(patt);
            //screen.Click(patt);


            username.SendKeys(LoginUser(user));
        }
        public void inputPasswordField(string user)
        {    // not all accounts can have the same password this 
             //if (user != "Valerie Hennessey")
             // {
            password.Clear();
            //passwordField.Clear()
            password.SendKeys("test123456");
            //passwordField.SendKeys("test123456");
            // } else
            // {
            //password.Clear();
            // //passwordField.Clear();
            // password.SendKeys("jack123456");   
            // //passwordField.SendKeys("jack123456");
            // }

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
            unitOfMeasureTl.SendKeys("Hour");
            unitPrice.Click();
            Thread.Sleep(5000);
            unitPrice.SendKeys("20");
            supplierOnNonCat.SendKeys("Think Forward Consulting");
            supplierContact.Click();
            Thread.Sleep(5000);
            supplierContact.SendKeys("Test Contant Name");
            supplierContactPhone.Click();
            supplierContactPhone.SendKeys("8099880000");
            Thread.Sleep(1000);
            addToCart.Click();
            Thread.Sleep(2000);
            checkout.Click();
        }
        public void clickCheckOut()
        {
            checkout_uixr.Click();
        }
        public void fillRequisitionInformation()
        {
            Thread.Sleep(1000);
            projectOnSummaryExpense.SendKeys("21553");
            taskExpense.Click();
            Thread.Sleep(5000);
            taskExpense.SendKeys("1100");
            expenditureTypeOnSummary.Click();
            Thread.Sleep(2000);
            expenditureTypeOnSummary.SendKeys("Misc Professional Sv");
            expenditureItemDate.Click();
            Thread.Sleep(2000);
            //Console.WriteLine(DateTime.Today.ToString("dd-MMMM-yyyy"));
            expenditureItemDate.SendKeys(string.Format("{0:dd-MMM-yyyy}", DateTime.Today));
            nextButtons.Click();
        }
        public void clickManageGraphButton()
        {
            manageGraphButton.Click();
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
            manageGraphButton.Click();

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

    }
}