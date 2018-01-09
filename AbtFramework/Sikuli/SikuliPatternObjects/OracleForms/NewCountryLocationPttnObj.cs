using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class NewCountryLocationPttnObj
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/NewCountryLocationPttnImgs/";
        private SikuliHelper sikuliHelper;
        public NewCountryLocationPttnObj()
        {
            sikuliHelper = SikuliHelper.GetInstance();
        }

        public IPattern GetTypeInputField => sikuliHelper.GetPattern(PATH + "TypeInputField.PNG", 5);

        public IPattern GetScrollDownArrow => sikuliHelper.GetPattern(PATH + "ScrollDownArrow.PNG", 5);

        public IPattern GetCodeInputField => sikuliHelper.GetPattern(PATH + "CodeInputField.PNG", 5);

        public IPattern GetCountryNameInput => sikuliHelper.GetPattern(PATH + "CountryNameInput.PNG", 5);

        public IPattern GetFromDateInput => sikuliHelper.GetPattern(PATH + "FromDateInput.PNG", 5);

        public IPattern GetContinueToLastRecord => sikuliHelper.GetPattern(PATH + "ContinueToLastRecord.PNG", 5);

        public IPattern GetSequenceNumberInput => sikuliHelper.GetPattern(PATH + "SequenceNumberInput.PNG", 5);

        public IPattern GetCountryName => sikuliHelper.GetPattern(PATH + "CountryName.PNG", 5);

        public IPattern GetSelectBtn => sikuliHelper.GetPattern(PATH + "SelectBtn.PNG", 5);

        public IPattern GetSelectedCountryAndorra => sikuliHelper.GetPattern(PATH + "SelectedCountryAndorra.PNG", 5);

        public IPattern GetGradeNum02 => sikuliHelper.GetPattern(PATH + "GradeNum02.PNG", 5);

        public IPattern GetGradeNum03 => sikuliHelper.GetPattern(PATH + "GradeNum03.PNG", 5);

        public IPattern GetFirstGradeName => sikuliHelper.GetPattern(PATH + "FirstGradeName.PNG", 5);
    }
}
