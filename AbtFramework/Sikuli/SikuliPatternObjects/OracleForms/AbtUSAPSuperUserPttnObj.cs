using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class AbtUSAPSuperUserPttnObj
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/AbtUSAPSuperUserPttnImgs/";
        private SikuliHelper sikuliHelper;

        public AbtUSAPSuperUserPttnObj()
        {
            sikuliHelper = SikuliHelper.GetInstance();
        }

        public IPattern GetBatchInputField => sikuliHelper.GetPattern(PATH + "BatchInputField.PNG", 5);

        public IPattern GetEnterBtn => sikuliHelper.GetPattern(PATH + "EnterBtn.PNG", 5);

        public IPattern GetTypeField => sikuliHelper.GetPattern(PATH + "TypeField.PNG", 5);

        public IPattern GetSelectBtn => sikuliHelper.GetPattern(PATH + "SelectBtn.PNG", 5);

        public IPattern GetOkBtn => sikuliHelper.GetPattern(PATH + "OkBtn.PNG", 5);

        public IPattern GetInvoiceNumInput => sikuliHelper.GetPattern(PATH + "InvoiceNumInput.PNG", 5);

        public IPattern GetInvoiceDateField => sikuliHelper.GetPattern(PATH + "InvoiceDateField.PNG", 5);

        public IPattern GetSelectedDate => sikuliHelper.GetPattern(PATH + "SelectedDate.PNG", 5);

        public IPattern GetOkDate => sikuliHelper.GetPattern(PATH + "OkDate.PNG", 5);

        public IPattern GetSupplierField => sikuliHelper.GetPattern(PATH + "SupplierField.PNG", 5);

        public IPattern GetFindInputField => sikuliHelper.GetPattern(PATH + "FindInputField.PNG", 5);

        public IPattern GetFindBtn => sikuliHelper.GetPattern(PATH + "FindBtn.PNG", 5);

        public IPattern GetInvoiceAmountInput => sikuliHelper.GetPattern(PATH + "InvoiceAmountInput.PNG", 5);

        public IPattern GetLineNumInput => sikuliHelper.GetPattern(PATH + "LineNumInput.PNG", 5);

        public IPattern GetLineTypeField => sikuliHelper.GetPattern(PATH + "LineTypeField.PNG", 5);

        public IPattern GetAmountInputField => sikuliHelper.GetPattern(PATH + "AmountInputField.PNG", 5);

        public IPattern GetCreateInvoicesBtn => sikuliHelper.GetPattern(PATH + "CreateInvoicesBtn.PNG", 5);

        public IPattern GetOkBtnProcessingInvoiceNote => sikuliHelper.GetPattern(PATH + "OkBtnProcessingInvoiceNote.PNG", 5);
    }
}
