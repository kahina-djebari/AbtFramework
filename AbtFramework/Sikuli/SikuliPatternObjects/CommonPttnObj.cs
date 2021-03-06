﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SikuliSharp;

namespace AbtFramework.Sikuli.SikuliPatternObjects
{
    public class CommonPttnObj
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/CommonPttnImgs/";
        private SikuliHelper sikuliHelper;

        public CommonPttnObj()
        {
            sikuliHelper = SikuliHelper.GetInstance();

        }

        public IPattern GetRunOracleBtn => sikuliHelper.GetPattern(PATH + "RunBtn.PNG", 5);

        public IPattern GetRunOracleSecurityWarning => sikuliHelper.GetPattern(PATH + "SecurityWarningRunBtn.PNG", 5);

        public IPattern GetAcceptCheckBoxSecurityWarning => sikuliHelper.GetPattern(PATH + "SecurityWarningCheckBoxIAccept.PNG", 5);

        public IPattern GetFindBtn => sikuliHelper.GetPattern(PATH + "FindBtn.PNG", 5);

        public IPattern GetNoBtn => sikuliHelper.GetPattern(PATH + "NoBtn.PNG", 5);

        public IPattern GetFullName => sikuliHelper.GetPattern(PATH + "FullName.PNG", 5);

        public IPattern GetCloseOracleForm => sikuliHelper.GetPattern(PATH + "CloseOracleForm.PNG", 5);

        public IPattern GetOkBtnCloseOracleForm => sikuliHelper.GetPattern(PATH + "OkBtnCloseOracleForm.PNG", 5);

        public IPattern GetCloseWindow => sikuliHelper.GetPattern(PATH + "CloseWindow.PNG", 5);

        public IPattern GetDesktopActivities => sikuliHelper.GetPattern(PATH + "DesktopActivities.PNG", 5);

        public IPattern GetSaveIcon => sikuliHelper.GetPattern(PATH + "SaveIcon.PNG", 5);

        public IPattern GetName => sikuliHelper.GetPattern(PATH + "Name.PNG", 5);

        public IPattern GetDownArrow => sikuliHelper.GetPattern(PATH + "DownArrow.PNG", 5);

        public IPattern GetViewPersonLifeEvents => sikuliHelper.GetPattern(PATH + "ViewPersonLifeEvents.PNG", 5);

        public IPattern GetCloseOracleWindows => sikuliHelper.GetPattern(PATH + "CloseOracleWindows.PNG", 5);

        public IPattern GetOkNotificationsNote => sikuliHelper.GetPattern(PATH + "OkNotificationsNote.PNG", 5);

        public IPattern GetMaximizeWindow => sikuliHelper.GetPattern(PATH + "MaximizeWindow.PNG", 5);

        public IPattern GetView => sikuliHelper.GetPattern(PATH + "View.PNG", 5);

        public IPattern GetQueryByExample => sikuliHelper.GetPattern(PATH + "QueryByExample.PNG", 5);

        public IPattern GetRun => sikuliHelper.GetPattern(PATH + "Run.PNG", 5);

        public IPattern GetEnter => sikuliHelper.GetPattern(PATH + "Enter.PNG", 5);

        public IPattern GetDownArrowKey => sikuliHelper.GetPattern(PATH + "DownArrowKey.PNG", 5);

        public IPattern GetFindIcon => sikuliHelper.GetPattern(PATH + "FindIcon.PNG", 5);

        public IPattern GetOfficeDetailsBtn => sikuliHelper.GetPattern(PATH + "OfficeDetailsBtn.PNG", 5);

        public IPattern GetOfficeFieldDisabled => sikuliHelper.GetPattern(PATH + "OfficeFieldDisabled.PNG", 5);

        public IPattern GetRecord => sikuliHelper.GetPattern(PATH + "Record.PNG", 5);

        public IPattern GetLastRecord => sikuliHelper.GetPattern(PATH + "LastRecord.PNG", 5);

        public IPattern GetNewIcon => sikuliHelper.GetPattern(PATH + "NewIcon.PNG", 5);

        public IPattern GetOkBtn => sikuliHelper.GetPattern(PATH + "OkBtn.PNG", 5);

        public IPattern GetOkButton => sikuliHelper.GetPattern(PATH + "OkButton.PNG", 5);

        public IPattern GetFindInputField => sikuliHelper.GetPattern(PATH + "FindInputField.PNG", 5);

        public IPattern GetFindButton => sikuliHelper.GetPattern(PATH + "FindButton.PNG", 5);

        public IPattern GetCalendarIcon => sikuliHelper.GetPattern(PATH + "CalendarIcon.PNG", 5);

        public IPattern GetClearRecordIcon => sikuliHelper.GetPattern(PATH + "ClearRecordIcon.PNG", 5);

        public IPattern GetSelectBtn => sikuliHelper.GetPattern(PATH + "SelectBtn.PNG", 5);

        public IPattern GetSubmitBtn => sikuliHelper.GetPattern(PATH + "SubmitBtn.PNG", 5);

        public IPattern GetViewLogBtn => sikuliHelper.GetPattern(PATH + "ViewLogBtn.PNG", 5);

        public IPattern GetFindRequestsBtn => sikuliHelper.GetPattern(PATH + "FindRequestsBtn.PNG", 5);

        public IPattern GetPhaseCompleted => sikuliHelper.GetPattern(PATH + "PhaseCompleted.PNG", 5);

        public IPattern GetStatusNormal => sikuliHelper.GetPattern(PATH + "StatusNormal.PNG", 5);

        public IPattern GetViewOutputBtn => sikuliHelper.GetPattern(PATH + "ViewOutputBtn.PNG", 5);

        public IPattern GetSubmitNewRequestBtn => sikuliHelper.GetPattern(PATH + "SubmitNewRequestBtn.PNG", 5);

    }
}
