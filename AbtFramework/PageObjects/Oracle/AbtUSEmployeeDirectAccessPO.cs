using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class AbtUSEmployeeDirectAccessPO
    {
        public IWebElement GetSearchVeteranStatusBtn()
        {
            string xpath = "//span[contains(text(),'Choose Your Veteran Status')]/parent::td/following-sibling::td[2]/child::span/child::a";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSearchVeteranStatusInputBox()
        {
            string xpath = "//input[@title='Search Term']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetQuickSelect2()
        {
            string xpath = "//input[@title = 'Select']";
            return SeleniumDriver.GetListElementByXpath(xpath)[1];
        }

        public IWebElement GetDateInput()
        {
            string xpath = "//span[contains(text(),'Enter Your Name')]/parent::td/parent::tr/following-sibling::tr/child::td[3]//child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetApplyBtn()
        {
            string xpath = "//button[@title='Apply']";
            return SeleniumDriver.GetListElementByXpath(xpath)[0];
        }

        public IWebElement GetNextBtn()
        {
            string xpath = "//h1[text()='Extra Information']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
        
        public IWebElement GetSubmitBtn()
        {
            string xpath = "//h1[text()='Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
        //OracleESS: Update personal information
        public IWebElement GetUpdateBasicDetails()
        {
            string xpath = "//h2[text()='Basic Details']/parent::div//descendant::button[@title='Update']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetUpdatePhoneNumbers()
        {
            string xpath = "//h2[text()='Phone Numbers']/parent::div//descendant::button[@title='Update']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetUpdateEmergencyContacts()
        {
            string xpath = "//span[text()='Select Emergency Contact:']/following-sibling::button[@title='Update the Contact Details']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNextChooseBtn()
        {
            string xpath = "//h1[contains(text(),'Basic Details')]/parent::div/descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNextPhoneNumBtn()
        {
            string xpath = "//h1[contains(text(),'Phone Numbers')]/parent::div/descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }


        public IWebElement GetNextEmergencyContact()
        {
            string xpath = "//h1[contains(text(),'Emergency Contact')]/parent::div/descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        // Works for Basic Details and Emergency Contacts
        public IWebElement GetMiddleNameInputField()
        {
            string xpath = "//span[text()='Middle Name']/parent::td//following-sibling::td/input[@title='Middle Name']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetEffectiveDateBasicDetails()
        {
            string xpath = "//span[contains(text(),'Effective Date')]/parent::td/following-sibling::td//descendant::input[@title='Effective Date']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        // Works for Basic Details, Phone Numbers, and Emergency Contacts
        public IWebElement GetCancelInfoChanges()
        {
            string xpath = "//h1[contains(text(),'Personal Information')]/parent::div/descendant::button[@title='Cancel']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        //to confirm that we want to cancel the changes that we have made
        public IWebElement GetYesBtn()
        {
            string xpath = "//button[@title='Yes']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSubmitInfoChange()
        {
            string xpath = "//h1[contains(text(),'Personal Information')]/parent::div/descendant::button[@title='Submit']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetPhoneNumInputField()
        {
            string xpath = "//span[text()='Number']/parent::th/parent::tr/following-sibling::tr[1]//child::td/input[@title='Text input for Phone number']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        //OracleESS: Confirm view and add beneficiaries
        public IWebElement GetSelectElectionsDate()
        {
            string xpath = "//span[text()='Please show me the benefits as of']/parent::td//following-sibling::td/select";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetGoToElections()
        {
            string xpath = "//span[text()='Please show me the benefits as of']/parent::td/ancestor::td/following-sibling::td/button[text()='Go']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetUpdateBeneficiariesBtn()
        {
            string xpath = "//button[@title='Update Beneficiaries']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetAddAnotherPersonBtn()
        {
            string xpath = "//button[@title='Add Another Person']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSelectRelationship()
        {
            string xpath = "//span[contains(text(),'Relationship')]/parent::td/following-sibling::td/select";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetBeneficiaryFirstName()
        {
            string xpath = "//input[@title='First Name']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetBeneficiaryLastName()
        {
            string xpath = "//input[@title='Last Name']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        //check this box instead of typing the address
        public IWebElement GetSharedResidenceCheckBox()
        {
            string xpath = "//span[contains(text(),'If you check the box above')]/ancestor::tr[1]/preceding-sibling::tr/descendant::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSelectGender()
        {
            string xpath = "//span[text()='Gender']/parent::td/following-sibling::td/select";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetDOBInputField()
        {
            string xpath = "//input[@title='Date of Birth']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetApplyNewBeneficiary()
        {
            string xpath = "//h1[text()='Add Dependents and Beneficiaries']/parent::div//descendant::button[@title='Apply']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNextToUpdateBeneficiaries()
        {
            string xpath = "//h1[text()='Dependents and Beneficiaries']/parent::div//descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNextToConfirmation()
        {
            string xpath = "//h1[text()='Update Beneficiaries']/parent::div//descendant::button[@title='Next to Confirmation Statement']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetFinishBtn()
        {
            string xpath = "//h1[text()='Confirmation Statement']/parent::div//descendant::button[@title='Back to Overview']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
    }
}
