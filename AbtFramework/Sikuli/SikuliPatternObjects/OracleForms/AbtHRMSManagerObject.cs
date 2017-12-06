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

        public IPattern GetNoBtn => sikuliHelper.GetPattern(PATH + "NoBtn.PNG", 5);

        public IPattern GetFullName => sikuliHelper.GetPattern(PATH + "FullName.PNG", 5);

        public IPattern GetFindBtn => sikuliHelper.GetPattern(PATH + "FindBtn.PNG", 5);

        public IPattern GetOfficeDetails => sikuliHelper.GetPattern(PATH + "OfficeDetailsBtn.PNG", 5);

        public IPattern GetOfficeInputField => sikuliHelper.GetPattern(PATH + "OfficeInputField.PNG", 5);

        public IPattern GetCorrectionBtn => sikuliHelper.GetPattern(PATH + "CorrectionBtn.PNG", 5);

        public IPattern GetSaveIcon => sikuliHelper.GetPattern(PATH + "SaveIcon.PNG", 5);

        public IPattern GetCloseOracleForm => sikuliHelper.GetPattern(PATH + "CloseOracleForm.PNG", 5);

        public IPattern GetOkBtn => sikuliHelper.GetPattern(PATH + "OkBtn.PNG", 5);

        public IPattern GetCloseWindow => sikuliHelper.GetPattern(PATH + "CloseWindow.PNG", 5);

    }
}
