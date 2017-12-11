using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SikuliSharp;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    /// <summary>
    /// Object class that holds all patterns for Oracle Forms
    /// </summary>

    public class OracleFormsPatternObject

    {    
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/OracleFromsImges/";
        private SikuliHelper sikuliHelper;

        public OracleFormsPatternObject()
        {
            sikuliHelper = SikuliHelper.GetInstance();

        }

        public IPattern GetDescriptionInput1 => sikuliHelper.GetPattern(PATH +"descriptionInput1.PNG");

       
        public IPattern GetNum => sikuliHelper.GetPattern(PATH + "Num.PNG");

        public IPattern GetType => sikuliHelper.GetPattern(PATH + "Type.PNG");

        public IPattern GetSelectBtn => sikuliHelper.GetPattern(PATH + "SelectBtn.PNG");

        public IPattern GetSelectGoods => sikuliHelper.GetPattern(PATH + "SelectGoods.PNG");

        public IPattern GetOkBtn => sikuliHelper.GetPattern(PATH + "OkBtn.PNG");

        public IPattern GetCategory => sikuliHelper.GetPattern(PATH + "Category.PNG");

        public IPattern GetSelectBtn2 => sikuliHelper.GetPattern(PATH + "SelectBtn2.PNG");

        public IPattern GetSelectFunding => sikuliHelper.GetPattern(PATH + "SelectFunding.PNG");

        public IPattern GetSelectBtn3 => sikuliHelper.GetPattern(PATH + "SelectBtn3.PNG");

        public IPattern GetSelectIncrease => sikuliHelper.GetPattern(PATH + "SelectIncrease.PNG");

        public IPattern GetOkBtn2 => sikuliHelper.GetPattern(PATH + "OkBtn2.PNG");

        public IPattern GetDescriptionInput2 => sikuliHelper.GetPattern(PATH + "DescriptionInput2.PNG");

        public IPattern GetUOM => sikuliHelper.GetPattern(PATH + "UOM.PNG");

        public IPattern GetSelectBtn4 => sikuliHelper.GetPattern(PATH + "SelectBtn4.PNG");

        public IPattern GetSelectEach => sikuliHelper.GetPattern(PATH + "SelectEach.PNG");

        public IPattern GetQuantity => sikuliHelper.GetPattern(PATH + "Quantity.PNG");

        public IPattern GetRightArrow => sikuliHelper.GetPattern(PATH + "RightArrow.PNG");

        public IPattern GetPrice => sikuliHelper.GetPattern(PATH + "Price.PNG");

        public IPattern GetNeedBy => sikuliHelper.GetPattern(PATH + "NeedBy.PNG");

        public IPattern GetSelectDate => sikuliHelper.GetPattern(PATH + "SelectDate.PNG");

        public IPattern GetOkBtn3 => sikuliHelper.GetPattern(PATH + "OkBtn3.PNG");

        public IPattern GetOrganization => sikuliHelper.GetPattern(PATH + "Organization.PNG");

        public IPattern GetSelectOrganization => sikuliHelper.GetPattern(PATH + "SelectOrganization.PNG");

        public IPattern GetFindLocation => sikuliHelper.GetPattern(PATH + "Find.PNG");

        public IPattern GetFindBtn => sikuliHelper.GetPattern(PATH + "FindBtn.PNG");

        public IPattern GetLocation => sikuliHelper.GetPattern(PATH + "Location.PNG");

        public IPattern GetDistributions => sikuliHelper.GetPattern(PATH + "DistributionsBtn.PNG");

        public IPattern GetProjectBtn => sikuliHelper.GetPattern(PATH + "ProjectBtn.PNG");

        public IPattern GetFind2 => sikuliHelper.GetPattern(PATH + "Find2.PNG");

        public IPattern GetProjectType => sikuliHelper.GetPattern(PATH + "ProjectType.PNG");

        public IPattern GetDate => sikuliHelper.GetPattern(PATH + "Date.PNG");   

        public IPattern GetSaveIcon => sikuliHelper.GetPattern(PATH + "SaveIcon.PNG");

        public IPattern GetCloseWindow => sikuliHelper.GetPattern(PATH + "CloseWindow.PNG");

        public IPattern GetApproveBtn => sikuliHelper.GetPattern(PATH + "ApproveBtn.PNG");

        public IPattern GetOkBtn4 => sikuliHelper.GetPattern(PATH + "OkBtn4.PNG");

    }
}