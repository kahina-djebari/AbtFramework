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

        public IPattern GetDescriptionInput1 => Patterns.FromFile(PATH +"descriptionInput1.PNG");

        public IPattern GetRunOracleBtn => Patterns.FromFile(PATH + "RunBtn.PNG");

        public IPattern GetNum => Patterns.FromFile(PATH + "Num.PNG");

        public IPattern GetType => Patterns.FromFile(PATH + "Type.PNG");

        public IPattern GetSelectBtn => Patterns.FromFile(PATH + "SelectBtn.PNG");

        public IPattern GetSelectGoods => Patterns.FromFile(PATH + "SelectGoods.PNG");

        public IPattern GetOkBtn => Patterns.FromFile(PATH + "OkBtn.PNG");

        public IPattern GetCategory => Patterns.FromFile(PATH + "Category.PNG");

        public IPattern GetSelectBtn2 => Patterns.FromFile(PATH + "SelectBtn2.PNG");

        public IPattern GetSelectFunding => Patterns.FromFile(PATH + "SelectFunding.PNG");

        public IPattern GetSelectBtn3 => Patterns.FromFile(PATH + "SelectBtn3.PNG");

        public IPattern GetSelectIncrease => Patterns.FromFile(PATH + "SelectIncrease.PNG");

        public IPattern GetOkBtn2 => Patterns.FromFile(PATH + "OkBtn2.PNG");

        public IPattern GetDescriptionInput2 => Patterns.FromFile(PATH + "DescriptionInput2.PNG");

        public IPattern GetUOM => Patterns.FromFile(PATH + "UOM.PNG");

        public IPattern GetSelectBtn4 => Patterns.FromFile(PATH + "SelectBtn4.PNG");

        public IPattern GetSelectEach => Patterns.FromFile(PATH + "SelectEach.PNG");

        public IPattern GetQuantity => Patterns.FromFile(PATH + "Quantity.PNG");

        public IPattern GetRightArrow => Patterns.FromFile(PATH + "RightArrow.PNG");

        public IPattern GetPrice => Patterns.FromFile(PATH + "Price.PNG");

        public IPattern GetNeedBy => Patterns.FromFile(PATH + "NeedBy.PNG");

        public IPattern GetSelectDate => Patterns.FromFile(PATH + "SelectDate.PNG");

        public IPattern GetOkBtn3 => Patterns.FromFile(PATH + "OkBtn3.PNG");

        public IPattern GetOrganization => Patterns.FromFile(PATH + "Organization.PNG");

        public IPattern GetSelectOrganization => Patterns.FromFile(PATH + "SelectOrganization.PNG");

        public IPattern GetFindLocation => Patterns.FromFile(PATH + "Find.PNG");

        public IPattern GetFindBtn => Patterns.FromFile(PATH + "FindBtn.PNG");

        public IPattern GetLocation => Patterns.FromFile(PATH + "Location.PNG");

        public IPattern GetDistributions => Patterns.FromFile(PATH + "DistributionsBtn.PNG");

        public IPattern GetProjectBtn => Patterns.FromFile(PATH + "ProjectBtn.PNG");

        public IPattern GetFind2 => Patterns.FromFile(PATH + "Find2.PNG");

        public IPattern GetProjectType => Patterns.FromFile(PATH + "ProjectType.PNG");

        public IPattern GetDate => Patterns.FromFile(PATH + "Date.PNG");   

        public IPattern GetSaveIcon => Patterns.FromFile(PATH + "SaveIcon.PNG");

        public IPattern GetCloseWindow => Patterns.FromFile(PATH + "CloseWindow.PNG");

        public IPattern GetApproveBtn => Patterns.FromFile(PATH + "ApproveBtn.PNG");

        public IPattern GetOkBtn4 => Patterns.FromFile(PATH + "OkBtn4.PNG");
    }
}