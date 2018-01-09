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

        public IPattern GetPayeeNameInput => sikuliHelper.GetPattern(PATH + "PayeeNameInput.PNG", 5);

        public IPattern GetPaymentOverviewBtn => sikuliHelper.GetPattern(PATH + "PaymentOverviewBtn.PNG", 5);

        public IPattern GetNameInputField => sikuliHelper.GetPattern(PATH + "NameInputField.PNG", 5);

        public IPattern GetPercentageInputField => sikuliHelper.GetPattern(PATH + "PercentageInputField.PNG", 5);

        public IPattern GetAccountField => sikuliHelper.GetPattern(PATH + "AccountField.PNG", 5);

        public IPattern GetSelectButton => sikuliHelper.GetPattern(PATH + "SelectButton.PNG", 5);

        public IPattern GetScrollLeftArrow => sikuliHelper.GetPattern(PATH + "ScrollLeftArrow.PNG", 5);

        public IPattern GetInvoiceNumToHold => sikuliHelper.GetPattern(PATH + "InvoiceNumToHold.PNG", 5);

        public IPattern GetHoldsTab => sikuliHelper.GetPattern(PATH + "HoldsTab.PNG", 5);

        public IPattern GetHoldReasonField => sikuliHelper.GetPattern(PATH + "HoldReasonField.PNG", 5);

        public IPattern GetSelectHoldName => sikuliHelper.GetPattern(PATH + "SelectHoldName.PNG", 5);
    }
}
