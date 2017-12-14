using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class LifeEventPatternObjects
    {
        private SikuliHelper sikuliHelper;

        public LifeEventPatternObjects()
        {
            sikuliHelper = SikuliHelper.GetInstance();
        }

        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/LifeEventImgs/";

        public IPattern GetPotentialLifeEventsTab => sikuliHelper.GetPattern(PATH + "PotentialLifeEventsTab.PNG", 5);

        public IPattern GetDownArrow => sikuliHelper.GetPattern(PATH + "DownArrow.PNG", 5);

        public IPattern GetLastEventRecorded => sikuliHelper.GetPattern(PATH + "LastEventRecorded.PNG", 5);

        public IPattern GetNewIcon => sikuliHelper.GetPattern(PATH + "NewIcon.PNG", 5);

        public IPattern GetSelectBtn => sikuliHelper.GetPattern(PATH + "SelectBtn.PNG", 5);

        public IPattern GetAbtAdminLE => sikuliHelper.GetPattern(PATH + "AbtAdminLE.PNG", 5);

        public IPattern GetOkBtnValidateLEReason => sikuliHelper.GetPattern(PATH + "OkBtnValidateLEReason.PNG", 5);

        public IPattern GetSelectLEDate => sikuliHelper.GetPattern(PATH + "SelectLEDate.PNG", 5);

        public IPattern GetOkBtnValidateLEDate => sikuliHelper.GetPattern(PATH + "OkBtnValidateLEDate.PNG", 5);

        public IPattern GetUnprocessedField => sikuliHelper.GetPattern(PATH + "UnprocessedField.PNG", 5);

        public IPattern GetAbtOAB => sikuliHelper.GetPattern(PATH + "AbtOABSelfServiceMasterEnrollment.PNG", 5);

        public IPattern GetCloseWindows => sikuliHelper.GetPattern(PATH + "CloseWindows.PNG", 5);

        public IPattern GetCommitBtn => sikuliHelper.GetPattern(PATH + "CommitBtn.PNG", 5);

        public IPattern GetEnrollmentOpportunities => sikuliHelper.GetPattern(PATH + "EnrollmentOpportunities.PNG", 5);

        public IPattern GetLatestLE => sikuliHelper.GetPattern(PATH + "LatestLE.PNG", 5);

        public IPattern GetOkBtnValidateAbtOAB => sikuliHelper.GetPattern(PATH + "OkBtnValidateAbtOAB.PNG", 5);

        public IPattern GetProcessLifeEvent => sikuliHelper.GetPattern(PATH + "ProcessLifeEvent.PNG", 5);

        public IPattern GetSwitchResponsabilityIcon => sikuliHelper.GetPattern(PATH + "SwitchResponsabilityIcon.PNG", 5);


    }
}
