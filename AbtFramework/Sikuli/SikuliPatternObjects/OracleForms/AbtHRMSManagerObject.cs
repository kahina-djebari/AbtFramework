using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class AbtHRMSManagerObject
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/AbtHRMSManagerImges/";
        private SikuliHelper sikuliHelper;

        public AbtHRMSManagerObject()
        {
            sikuliHelper = SikuliHelper.GetInstance();

        }

        public IPattern GetOfficeDetails => sikuliHelper.GetPattern(PATH + "OfficeDetailsBtn.PNG", 5);

        public IPattern GetOfficeInputField => sikuliHelper.GetPattern(PATH + "OfficeInputField.PNG", 5);

        public IPattern GetCorrectionBtn => sikuliHelper.GetPattern(PATH + "CorrectionBtn.PNG", 5);


    }
}
