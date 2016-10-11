using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework.Utils_Classes
{
    public class TestCase
    {
        private string Name;
        private List<TestStep> Steps;
        private int StepsCompleted;
        private int StepsFailures;
        private int RunTime;

        public TestCase(string testName)
        {
            Steps = new List<TestStep>();
            Name = testName;
            StepsCompleted = 0;
            StepsFailures = 0;
            RunTime = 0;
        }

        public bool StepExist(string stepDescription)
        {
            if (Steps != null)
                if (Steps.Single(e => e.description.Equals(stepDescription)) != null)
                    return true;
            return false;
        }

        internal void AddStep(string line)
        {
            TestStep step = new TestStep();
            step.description = line;
            step.status = "Not Run";
            step.RunTime = "N/A";
            step.details = "";
            Steps.Add(step);
        }

        internal void PrintSteps()
        {
            foreach(var step in Steps)
            {
                Console.WriteLine(step.description);
            }
        }

       

        internal string GetName()
        {
            return Name;
        }

        internal string GetRunTime()
        {
            return RunTime.ToString();
        }

        internal string StepsCompletedCount()
        {
            return StepsCompleted.ToString();
        }

        internal string StepFailuresCount()
        {
            return StepsFailures.ToString();
        }

        internal int StepCount()
        {
            return Steps.Count();
        }

        internal List<TestStep> GetSteps()
        {

            return Steps;
        }

        internal void MarkStepAsDone(string stepDescription)
        {
            Steps.Single(e => e.description.Equals(stepDescription)).status="Passed";
            Steps.Single(e => e.description.Equals(stepDescription)).RunTime = DateTime.Now.ToString();
            StepsCompleted++;
            TestCaseGenerator.UpdateHtmlStep(Steps.IndexOf(Steps.Single(e => e.description.Equals(stepDescription))));
            TestCaseGenerator.UpdateDetailedSummary();
            TestCaseGenerator.MergeHtmlReport();
        }

        internal void MarkStepAsFailed(string stepDescription,string exception)
        {
            Steps.Single(e => e.description.Equals(stepDescription)).status = "Failed";
            Steps.Single(e => e.description.Equals(stepDescription)).RunTime = DateTime.Now.ToString();
            Steps.Single(e => e.description.Equals(stepDescription)).details = exception;
            StepsCompleted++;
            StepsFailures++;
            TestCaseGenerator.UpdateHtmlStep(Steps.IndexOf(Steps.Single(e => e.description.Equals(stepDescription))));
            TestCaseGenerator.UpdateDetailedSummary();
            TestCaseGenerator.MergeHtmlReport();
        }
    }
}