using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SikuliSharp;

namespace AbtFramework.Sikuli.SikuliPatternObjects
{
    public class CommonPaternObjects
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/CommonPatternImgs/";
        private SikuliHelper sikuliHelper;

        public CommonPaternObjects()
        {
            sikuliHelper = SikuliHelper.GetInstance();

        }

        public IPattern GetRunOracleBtn => sikuliHelper.GetPattern(PATH + "RunBtn.PNG",5);

        public IPattern GetRunOracleSecurityWarning => sikuliHelper.GetPattern(PATH + "SecurityWarningRunBtn.PNG",5);

        public IPattern GetAcceptCheckBoxSecurityWarning => sikuliHelper.GetPattern(PATH + "SecurityWarningCheckBoxIAccept.PNG",5);

        public IPattern GetFindBtn => sikuliHelper.GetPattern(PATH + "FindBtn.PNG", 5);

        public IPattern GetNoBtn => sikuliHelper.GetPattern(PATH + "NoBtn.PNG", 5);

        public IPattern GetFullName => sikuliHelper.GetPattern(PATH + "FullName.PNG", 5);

        public IPattern GetCloseOracleForm => sikuliHelper.GetPattern(PATH + "CloseOracleForm.PNG", 5);

        public IPattern GetOkBtn => sikuliHelper.GetPattern(PATH + "OkBtn.PNG", 5);

        public IPattern GetCloseWindow => sikuliHelper.GetPattern(PATH + "CloseWindow.PNG", 5);

        public IPattern GetDesktopActivities => sikuliHelper.GetPattern(PATH + "DesktopActivities.PNG", 5);

    }
}
