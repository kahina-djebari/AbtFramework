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

        public IPattern GetCommitAndProceedBtn => sikuliHelper.GetPattern(PATH + "CommitAndProceedBtn.PNG", 5);

        public IPattern GetEnrollmentOpportunitiesBtn => sikuliHelper.GetPattern(PATH + "EnrollmentOpportunitiesBtn.PNG", 5);

        public IPattern GetLatestLE => sikuliHelper.GetPattern(PATH + "LatestLE.PNG", 5);

        public IPattern GetOkBtnValidateAbtOAB => sikuliHelper.GetPattern(PATH + "OkBtnValidateAbtOAB.PNG", 5);

        public IPattern GetProcessLifeEvents => sikuliHelper.GetPattern(PATH + "ProcessLifeEvents.PNG", 5);

        public IPattern GetSwitchResponsabilityIcon => sikuliHelper.GetPattern(PATH + "SwitchResponsabilityIcon.PNG", 5);

        public IPattern GetEndDateInputField => sikuliHelper.GetPattern(PATH + "EndDateInputField.PNG", 5);

        public IPattern GetBenefitsOption => sikuliHelper.GetPattern(PATH + "BenefitsOption.PNG", 5);

        public IPattern GetYesToCloseActiveLE => sikuliHelper.GetPattern(PATH + "YesToCloseActiveLE.PNG", 5);

        public IPattern GetReturnToPeopleInHierarchyLink => sikuliHelper.GetPattern(PATH + "ReturnToPeopleInHierarchyLink.PNG", 5);

        public IPattern GetEmployeeNameInputField => sikuliHelper.GetPattern(PATH + "EmployeeNameInputField.PNG", 5);

        public IPattern GetGoBtn => sikuliHelper.GetPattern(PATH + "GoBtn.PNG", 5);

        public IPattern GetActionIcon => sikuliHelper.GetPattern(PATH + "ActionIcon.PNG", 5);

        public IPattern GetNextBtn => sikuliHelper.GetPattern(PATH + "NextBtn.PNG", 5);

        public IPattern GetAddAnotherPersonBtn => sikuliHelper.GetPattern(PATH + "AddAnotherPersonBtn.PNG", 5);

        public IPattern GetSelectRelationship => sikuliHelper.GetPattern(PATH + "SelectRelationship.PNG", 5);

        public IPattern GetSelectChild => sikuliHelper.GetPattern(PATH + "SelectChild.PNG", 5);

        public IPattern GetRelationshipStartDateInput => sikuliHelper.GetPattern(PATH + "RelationshipStartDateInput.PNG", 5);

        public IPattern GetFNameInputField => sikuliHelper.GetPattern(PATH + "FNameInputField.PNG", 5);

        public IPattern GetLNameInputField => sikuliHelper.GetPattern(PATH + "LNameInputField.PNG", 5);

        public IPattern GetSharedResidenceCheckBox => sikuliHelper.GetPattern(PATH + "SharedResidenceCheckBox.PNG", 5);

        public IPattern GetScrollDown => sikuliHelper.GetPattern(PATH + "ScrollDown.PNG", 5);

        public IPattern GetGenderSelect => sikuliHelper.GetPattern(PATH + "GenderSelect.PNG", 5);

        public IPattern GetMale => sikuliHelper.GetPattern(PATH + "Male.PNG", 5);

        public IPattern GetDOBInputField => sikuliHelper.GetPattern(PATH + "DOBInputField.PNG", 5);

        public IPattern GetApplyBtn => sikuliHelper.GetPattern(PATH + "ApplyBtn.PNG", 5);

        public IPattern GetUpdateBenefitsBtn => sikuliHelper.GetPattern(PATH + "UpdateBenefitsBtn.PNG", 5);

        public IPattern GetFinishBtn => sikuliHelper.GetPattern(PATH + "FinishBtn.PNG", 5);

        public IPattern GetCoverCheckBox => sikuliHelper.GetPattern(PATH + "CoverCheckBox.PNG", 5);
    }
}
