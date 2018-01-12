using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class SubmitReportPttnObj
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/SubmitReportPttnImgs/";
        private SikuliHelper sikuliHelper;

        public SubmitReportPttnObj()
        {
            sikuliHelper = SikuliHelper.GetInstance();
        }

        public IPattern GetOkBtnRequestType => sikuliHelper.GetPattern(PATH + "OkBtnRequestType.PNG", 5);

        public IPattern GetScrollDownArrow => sikuliHelper.GetPattern(PATH + "ScrollDownArrow.PNG", 5);

        public IPattern GetReportTypeToChoose => sikuliHelper.GetPattern(PATH + "ReportTypeToChoose.PNG", 5);

        public IPattern GetOkBtnValidateReportType => sikuliHelper.GetPattern(PATH + "OkBtnValidateReportType.PNG", 5);

        public IPattern GetOkToRequestSubmission => sikuliHelper.GetPattern(PATH + "OkToRequestSubmission.PNG", 5);

    }
}
