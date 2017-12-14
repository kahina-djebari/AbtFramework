using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class SubmitReportObjects
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/SubmitReportImgs/";
        private SikuliHelper sikuliHelper;

        public SubmitReportObjects()
        {
            sikuliHelper = SikuliHelper.GetInstance();
        }

        public IPattern GetOkBtnRequestType => sikuliHelper.GetPattern(PATH + "OkBtnRequestType.PNG", 5);

        public IPattern GetSelectReportType => sikuliHelper.GetPattern(PATH + "SelectReportType.PNG", 5);

        public IPattern GetScrollDownArrow => sikuliHelper.GetPattern(PATH + "ScrollDownArrow.PNG", 5);

        public IPattern GetReportTypeToChoose => sikuliHelper.GetPattern(PATH + "ReportTypeToChoose.PNG", 5);

        public IPattern GetOkBtnValidateReportType => sikuliHelper.GetPattern(PATH + "OkBtnValidateReportType.PNG", 5);

        public IPattern GetSubmitReportBtn => sikuliHelper.GetPattern(PATH + "SubmitReportBtn.PNG", 5);

        public IPattern GetOkToRequestSubmission => sikuliHelper.GetPattern(PATH + "OkToRequestSubmission.PNG", 5);

        public IPattern GetNoToSubmitAnotherRequest => sikuliHelper.GetPattern(PATH + "NoToSubmitAnotherRequest.PNG", 5);

        public IPattern GetFindRequestsBtn => sikuliHelper.GetPattern(PATH + "FindRequestsBtn.PNG", 5);

        public IPattern GetViewLogBtn => sikuliHelper.GetPattern(PATH + "ViewLogBtn.PNG", 5);
    }
}
