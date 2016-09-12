using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AbtFramework
{
    public class ConferencingSetupPage : PageModel
    {
        [FindsBy(How=How.CssSelector,Using = "#addRemoveButtons > a.btn.btn-default.icon-chevron-right")]
        private IWebElement addBtn;
        [FindsBy(How=How.Id,Using = "cs_conference_room_names_select_0")]
        private IWebElement ConferenceRoomList;
        [FindsBy(How=How.Id,Using = "IO:cd6f751128d20200615e8cc0be0e29d2")]
        private IWebElement EndDateInput;
        [FindsBy(How=How.Id,Using = "IO:e99092d128d20200615e8cc0be0e2986")]
        private IWebElement GotoMeetingchkBox;
        [FindsBy(How=How.Id,Using = "IO:b94496d128d20200615e8cc0be0e29a5")]
        private IWebElement Location;
        [FindsBy(How=How.Id,Using = "IO:139212d128d20200615e8cc0be0e2957")]
        private IWebElement participantsInput;
        [FindsBy(How = How.Id, Using = "IO:cb7196d128d20200615e8cc0be0e293f")]
        private IWebElement MeetingInfo;
        [FindsBy(How=How.Id,Using = "IO:2a9e7d1128d20200615e8cc0be0e295e")]
        private IWebElement StartDateInput;



        [FindsBy(How = How.Id, Using = "IO:b4159ad128d20200615e8cc0be0e29d2")]
        public IWebElement PresentationMaterials;
        [FindsBy(How = How.Id, Using = "IO:68859ad128d20200615e8cc0be0e2993")]
        public IWebElement NeedTech;
        [FindsBy(How = How.Id, Using = "IO:fc4296d128d20200615e8cc0be0e2941")]
        public IWebElement AnyRemoteParticipant;
        [FindsBy(How=How.Id,Using = "order_now")]
        private IWebElement SubmitRequest;

        public void NewRequest(string presenterLocation, string startDate, string endDate, string conferenceRoom, string meetingInfo, string participantsNumber)
        {
            Location.SendKeys(presenterLocation);
            StartDateInput.SendKeys(startDate);
            EndDateInput.SendKeys(endDate);
            ConferenceRoomList.SelectOption(conferenceRoom).Click();
            addBtn.Click();
            GotoMeetingchkBox.Click();
            MeetingInfo.SendKeys(meetingInfo);
            participantsInput.SendKeys(participantsNumber);
            PresentationMaterials.SelectOption("No").Click();
            NeedTech.SelectOption("No").Click();
            AnyRemoteParticipant.SelectOption("No").Click();
            SubmitRequest.Click();
            
        }
    }
}