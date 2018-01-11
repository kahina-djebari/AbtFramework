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

        public IPattern GetSelectBtn => sikuliHelper.GetPattern(PATH + "SelectBtn.PNG", 5);

        public IPattern GetGradeNum02 => sikuliHelper.GetPattern(PATH + "GradeNum02.PNG", 5);

        public IPattern GetGradeNum03 => sikuliHelper.GetPattern(PATH + "GradeNum03.PNG", 5);

        public IPattern GetFirstGradeName => sikuliHelper.GetPattern(PATH + "FirstGradeName.PNG", 5);

        public IPattern GetNameInputField => sikuliHelper.GetPattern(PATH + "NameInputField.PNG", 5);

        public IPattern GetLocationNameInput => sikuliHelper.GetPattern(PATH + "LocationNameInput.PNG", 5);

        public IPattern GetCityInputField => sikuliHelper.GetPattern(PATH + "CityInputField.PNG", 5);

        public IPattern GetStateInputField => sikuliHelper.GetPattern(PATH + "StateInputField.PNG", 5);

        public IPattern GetCountyInputField => sikuliHelper.GetPattern(PATH + "CountyInputField.PNG", 5);

        public IPattern GetDescriptiveFlexField => sikuliHelper.GetPattern(PATH + "DescriptiveFlexField.PNG", 5);

        public IPattern GetCountryCodeInput => sikuliHelper.GetPattern(PATH + "CountryCodeInput.PNG", 5);

        public IPattern GetCountryShortNameInput => sikuliHelper.GetPattern(PATH + "CountryShortNameInput.PNG", 5);

        public IPattern GetGovReportingLocationInput => sikuliHelper.GetPattern(PATH + "GovReportingLocationInput.PNG", 5);

        public IPattern GetSelectButton => sikuliHelper.GetPattern(PATH + "SelectButton.PNG", 5);

        public IPattern GetZipCodeInput => sikuliHelper.GetPattern(PATH + "ZipCodeInput.PNG", 5);
    }
}
