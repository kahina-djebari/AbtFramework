using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbtFramework.Utils_Classes
{
    public class TestCaseGenerator
    {
       
        private static string[] HtmlReport;
        private static string HtmlBody;
        private static List<string> HtmlHeader;
        private static string RootSolutionPath;
        private static AbtTemplates currentTemplate;

        public static TestCase CurrentTestCase { get; set; }
        public static string HtmlTestName { get; private set; }
        public static string HtmlSummary { get; private set; }

        public static void SetTestCase(AbtTestCases testCase)
        {
            switch (testCase)
            {

                case AbtTestCases.Get_SuccessFactors_Prod_ResponseTime:

                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Go To SuccessFactors Production");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\SuccessFactorsProdResponseTime.txt");


                    break;

                case AbtTestCases.Get_ServiceNow_Prod_ResponseTime:

                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Go To ServiceNow(Production)");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\ServiceNowProdResponseTime.txt");

                    break;

                case AbtTestCases.Get_RightFindProd_Throug_AGI:

                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Go To RightFind");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\RightFindProdResponseThrouhAGI.txt");

                    break;

                case AbtTestCases.Get_Concur_Test_ResponseTime:

                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Get Concur(Test Environment) Response Time ");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\ConcurTestResponseTime.txt");

                    break;

                case AbtTestCases.Get_ServiceNow_Test_ResponseTime:

                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Get ServiceNow(Test Environment) Response Time ");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\ServiceNowTestResponseTime.txt");

                    break;
                case AbtTestCases.Get_RightFind_Test_ResponseTime:
                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Get RightFind(Test Environment) Response Time ");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\RightFindTestResponseTime.txt");



                    break;

                case AbtTestCases.Get_SuccessFactors_test_ResponseTime:
                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Get SuccessFactors(Test Environment) Response Time ");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\SuccessFactorsTestResponseTime.txt");


                    break;
                case AbtTestCases.Get_WebEx_TestEnv_ResponseTime:
                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Get WebEx (Test Environment) Response Time");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\WebExTestResponseTime.txt");

                    break;

                case AbtTestCases.Get_Ebsco_Test_ResponseTime:
                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Get Ebsco (Test Environment) Response Time");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\EbscoTestResponseTime.txt");

                    break;
                case AbtTestCases.Get_WeSpireTestResponseTime:

                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Get WeSpire (Test Environment) Response Time");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\WeSpireTestResponseTime.txt");
                    break;

                case AbtTestCases.Get_WeSpireHomePageResponseTime:
                    RootSolutionPath = MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Should Get WeSpire Response Time");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\WeSpireProdResponseTime.txt");
                    break;
                case AbtTestCases.Get_Concur_Prod_ResponseTime:
                    RootSolutionPath= MyUtils.GetRootSolutionPath();
                    CurrentTestCase = new TestCase("Get Concur Production Response Time");
                    CurrentTestCase.IsResponseTimeRequired = true;
                    LoadTestCase(RootSolutionPath + @"AbtFramework\TestPlans\ConcurProdResponseTime.txt");
                    break;
                default:
                    break;
            }
        }

        private static void LoadTestCase(string testCasePath)
        {
            StreamReader file = new StreamReader(testCasePath);
            string line;
            while((line = file.ReadLine()) != null)
            {
                CurrentTestCase.AddStep(line);
            }
        }

        public static void PrintTestCaseSteps()
        {
            CurrentTestCase.PrintSteps();
        }

        public static void SetTestCaseTemplate(AbtTemplates template)
        {
            switch (template)
            {
                case AbtTemplates.DetailedReport:
                     RootSolutionPath = MyUtils.GetRootSolutionPath();
                    currentTemplate = template;
                    CreateDetailedTemplate(RootSolutionPath);
                    
                    break;
                default:
                    break;
            }
        }

        private static void CreateDetailedTemplate(string templatePath)
        {
            SetHtmlHeader(templatePath);
            UpdateDetailedSummary();
            SetDetailedBody();
            CreateInitialHtmlSteps();
            SetFooter();
            MergeHtmlReport();
        }

        public static void MergeHtmlReport()
        {
            using (StreamWriter sw = File.CreateText(RootSolutionPath + @"\abtTest\HtmlResults\initialRun.html"))
            {
                foreach (string line in HtmlReport)
                {
                    sw.WriteLine(line);

                }

            }
         
        }

        private static void CreateInitialHtmlSteps()
        {
            for (int i = 0; i < CurrentTestCase.GetSteps().Count(); i++)
            {

                var step = "<tr ><td style=\"white - space:nowrap\">" + CurrentTestCase.GetSteps()[i].description + "</td><td style=\"white - space:nowrap\">" + CurrentTestCase.GetSteps()[i].status +
                "</td><td style =\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[i].RunTime + "</td><td style =\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[i].details + "</td></tr>";
                HtmlReport[HtmlHeader.Count + 3 + i] = step;
            }

        }

        public static void UpdateDetailedSummary()
        {
            //set test summary
            switch (currentTemplate)
            {
                case AbtTemplates.DetailedReport:
                    HtmlSummary = "<div>Steps Run:<a href=\"#\"><b>" + CurrentTestCase.StepsCompletedCount() +
                      "</b></a>;</br>Steps Failures:<a href=\"#\"><b>" + CurrentTestCase.StepFailuresCount() + "</b></a></br>" +
                      "Run Time:<b>" + CurrentTestCase.GetRunTime() + "</b></br>" +
                      "Response Time:<b>" + CurrentTestCase.GetResponseTime() + "</b></div>";
                    HtmlReport[HtmlHeader.Count + 1] = HtmlSummary;
                    break;

                case AbtTemplates.OktaPageResponse:
                    HtmlSummary = "<div>Steps Run:<a href=\"#\"><b>" + CurrentTestCase.StepsCompletedCount() +
                      "</b></a>;</br>Steps Failures:<a href=\"#\"><b>" + CurrentTestCase.StepFailuresCount() + "</b></a></br>" +
                      "Run Time:<b>" + CurrentTestCase.GetRunTime() + "</b></br>" +
                      "Response Time:<b>" + CurrentTestCase.GetResponseTime() + "</b></div>";
                    HtmlReport[HtmlHeader.Count + 1] = HtmlSummary;
                    break;
                default:

                    break;
            }
           
        }


        public static void UpdateHtmlStep(int stepPosition)
        {
            //Update Step Data
            if (CurrentTestCase.GetSteps()[stepPosition].status.Equals("Passed"))
            {
                var step = "<tr class=\"success\"><td style=\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].description + "</td><td style=\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].status +
             "</td><td style =\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].RunTime + "</td><td style =\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].details + "</td></tr>";
                HtmlReport[HtmlHeader.Count + 3 + stepPosition] = step;
            }
            if (CurrentTestCase.GetSteps()[stepPosition].status.Equals("Failed"))
            {
                var step = "<tr class=\"danger\"><td style=\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].description + "</td><td style=\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].status +
             "</td><td style =\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].RunTime + "</td><td style =\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].details + "</td></tr>";
                HtmlReport[HtmlHeader.Count + 3 + stepPosition] = step;
            }
            if (CurrentTestCase.GetSteps()[stepPosition].status.Equals("Not Run"))
            {
                var step = "<tr><td style=\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].description + "</td><td style=\"white - space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].status +
           "</td><td style =\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].RunTime + "</td><td style =\"white-space:nowrap\">" + CurrentTestCase.GetSteps()[stepPosition].details + "</td></tr>";
                HtmlReport[HtmlHeader.Count + 3 + stepPosition] = step;
            }



        }

        private static void SetFooter()
        {
            HtmlReport[HtmlReport.Count() - 1] = "</table></div></body></html>";
        }

        private static void SetDetailedBody()
        {
            //set step Body
            HtmlBody = "<table class=\"table table-striped\" border=\"1\"><tr bgcolor=\"#ccccff\"><th style=\"text-align:left\">Step</th><th style=\"text-align:left\">Status</th><th style=\"text-align:left\">Time</th><th style=\"text-align:left\">Details</th></tr>";
            HtmlReport[HtmlHeader.Count + 2] = HtmlBody;
        }

        private static void SetHtmlHeader(string templatePath)
        {
            //loads the html header
           // StreamReader file = new StreamReader(templatePath);
            HtmlHeader=HtmlRepository.GetAbtHtmlHeader();
          
            HtmlReport = new string[HtmlHeader.Count+CurrentTestCase.StepCount()+4]; //the lines in htmlheader+line per step+line for title+line for html summary+line for html body+ending tags
            HtmlHeader.CopyTo(0, HtmlReport, 0, HtmlHeader.Count);
            //set the test title
            HtmlTestName ="<h1>"+CurrentTestCase.GetName()+"</h1>";
            HtmlReport[HtmlHeader.Count() ] = HtmlTestName;
                            
         
            


      
        }
    }
}
