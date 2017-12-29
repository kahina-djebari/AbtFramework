using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class AbtHROperationsSelfServicePO
    {
        public IWebElement GetEffectiveDateInput()
        {
            string xpath = "//span[text()='Effective Date']/parent::td/following-sibling::td[2]//descendant::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSupervisorNameInput()
        {
            string xpath = "//input[@title='Manager']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetTimecardApproverInput()
        {
            string xpath = "//span[text()='Timecard Approver']/parent::td/following-sibling::td[2]//input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNextBtnValidateChangeManagerBtn()
        {
            string xpath = "//h1[text()='Change Timecard Approver and Supervisor: Change Manager']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetChangeReasonSelect()
        {
            string xpath = "//span[contains(text(),'Reason')]/parent::td/following-sibling::td//select";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNextBtnValidateAssignmentBtn()
        {
            string xpath = "//h1[text()='Change Timecard Approver and Supervisor: Assignment']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSubmitChangeTimecardApproverSupervisorBtn()
        {
            string xpath = "//h1[text()='Change Timecard Approver and Supervisor: Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetContinueChangeHoursBtn()
        {
            string xpath = "//h1[text()='Change Hours: Effective Date Options']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Continue']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetWorkHoursInputField()
        {
            string xpath = "//input[@title='Work Hours']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetAssignmentCategorySelect()
        {
            string xpath = "//span[text()='Assignment Category']/parent::td/following-sibling::td[2]//select";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNextBtnValidateWorkSchedule()
        {
            string xpath = "//h1[text()='Change Hours: Work Schedule']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetProposePayChangeBtn()
        {
            string xpath = "//button[@title='Propose Pay Change']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
        
        public IWebElement GetReasonForPayChangeSelect()
        {
            string xpath = "//span[text()='Reason For Pay Change']/parent::td/following-sibling::td[2]//select";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetActualPayAmountInput()
        {
            string xpath = "//input[@title='Actual Pay Amount']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetApplyPayDetailsButton()
        {
            string xpath = "//h1[text()='Change Hours: Pay Details']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Apply']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
        
        public IWebElement GetNextBtnValidatePayChangeProposal()
        {
            string xpath = "//h1[text()='Change Hours: Select A Pay Action']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSubmitChangeHoursBtn()
        {
            string xpath = "//h1[text()='Change Hours: Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetCommentsTextArea()
        {
            string name = "Comments";
            return SeleniumDriver.GetElementByName(name);
        }

        public IWebElement GetNextBtnAfterReason()
        {
            string id = "HrNext_uixr";
            return SeleniumDriver.GetElementByID(id);
        }

        public IWebElement GetTitleAttachmentInput()
        {
            string name = "FileName";
            return SeleniumDriver.GetElementByName(name);
        }

        public IWebElement GetDescrptionAttachmentTextArea()
        {
            string name = "AkDescription";
            return SeleniumDriver.GetElementByName(name);
        }

        public IWebElement GetDefineAttachmentTextRadioBtn()
        {
            string xpath = "//span[text()= 'Text']//preceding-sibling::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetApplyAttachmentBtn()
        {
            string id = "Okay_uixr";
            return SeleniumDriver.GetElementByID(id);
        }


        public IWebElement GetDescriptionTextAreaAttachment()
        {
            string xpath = "//textarea[@title='Attachment Text']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSubmitInReviewConfirmationBtn()
        {
            string id = "HrSubmit";
            return SeleniumDriver.GetElementByID(id);//works for any subit under review screen
        }

        public IWebElement GetPaymentTypeInput()
        {
            string xpath = "//span[text()='Payment Type']/parent::td/following-sibling::td//input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetPaymentDateInput()
        {
            string xpath = "//span[text()='Payment Date']/parent::td/following-sibling::td//input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetPaymentAmountInput()
        {
            string xpath = "//span[text()='Payment Amount']/parent::td/following-sibling::td//input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetPaymentBonusAwardedByIcon()
        {
            string xpath = "//img[@title='Search for Bonus Awarded By']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }


        public IWebElement GetPaymentCommentsInput()
        {
            string xpath = "//span[text()='Comments']/parent::td/following-sibling::td//input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetBonusAwardedBySearchInput()
        {
            string xpath = "//input[@title='Search Term']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetBonusAwardedSelecRadioBtn()
        {
            string xpath = "//input[@title='Select']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        //this works for apply and next in Bonus Spot section
        public IWebElement GetApplyOrNextBonusBtn()
        {
            string id = "HrNext";
            return SeleniumDriver.GetElementByID(id);
        }

        public IWebElement GetSelectBtnsList()
        {
            string xpath = "//button[text() = 'Select']";
            return SeleniumDriver.GetListElementByXpath(xpath)[0];
        }

        public IWebElement GetReturnToPeopleInHierarchyLink()
        {
            string xpath = "//a[@title = 'Return to People in Hierarchy']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }


    }
}
