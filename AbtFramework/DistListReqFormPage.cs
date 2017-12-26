using AbtFramework.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using AbtFramework.Utils_Classes;

namespace AbtFramework
{
    public class DistListReqFormPage : PageModel
    {
        [FindsBy(How = How.Id, Using = "IO:c5ce33e2c956020008e93481b82c211c")]
        private IWebElement ActionToPerform;
        [FindsBy(How=How.Id,Using = "addRemoveButtons")]
        private IList<IWebElement> AddOrRemoveBtn;
        [FindsBy(How = How.Id, Using = "IO:11bc13399ca64200615ec5391ae8d8ab")]
        private IWebElement CommentsInput;
        [FindsBy(How = How.Id, Using = "IO:0e1e3fe2c956020008e93481b82c2131")]
        private IWebElement DistNameInput;
        [FindsBy(How = How.Id, Using = "dlr_new_mailing_list_owner_select_0")]
        private IWebElement DistOwnerList;
        [FindsBy(How=How.Id,Using = "IO:b33b3be2c956020008e93481b82c21bc")]
        private IWebElement ModifyExisting;
        [FindsBy(How = How.Id, Using = "IO:b33b3be2c956020008e93481b82c21bc")]
        private IWebElement NewMailingList;
        [FindsBy(How=How.Id,Using = "order_now")]
        private IWebElement SubmitBtn;
        [FindsBy(How=How.Id,Using = "dlr_mailing_list_members_select_0")]
        private IWebElement UsersToAddOrRemove;

        public IWebElement AddBtn { get { return AddOrRemoveBtn.First().FindElements(By.TagName("a")).Single(e => e.GetAttribute("data-original-title").Equals("Add")); } }

        public IWebElement AddBtn2
        {
            get
            {
                foreach(var el in AddOrRemoveBtn)
                {
                    var btn = el.FindElements(By.TagName("a"))[0];
                    if(btn.GetAttribute("onclick").Equals("moveOptionAndSort(gel('dlr_mailing_list_members_select_0'), gel('dlr_mailing_list_members_select_1'), '--None--', [], '--None--');"))
                    {
                        return btn;
                    }
                }

                return null;



            }

        }

        public IWebElement RemoveBtn { get { return AddOrRemoveBtn.First().FindElements(By.TagName("a")).Single(e => e.GetAttribute("data-original-title").Equals("Remove")); } }

        public void NewRequest(string distName,TypeOfRequest typeOfRequest, string distOwner, string action, string userToAddOrRemove, string comments)
        {

            switch (typeOfRequest)
            {
                case TypeOfRequest.NewMailingList:
                    NewMailingList.Click();
                    break;

                case TypeOfRequest.ModifyExisting:
                    ModifyExisting.Click();
                    break;
                default:
                    break;
            }

            DistNameInput.SendKeys(distName);
            DistOwnerList.SelectOption(distOwner).Click();
            AddBtn.Click();
            ActionToPerform.SelectOption(action).Click();
            UsersToAddOrRemove.SelectOption(userToAddOrRemove).Click();
            AddBtn2.Click();
            CommentsInput.SendKeys(comments);
            SubmitBtn.Click();

        }
    }
}