using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Student : IStudent
    {
        private List<string> testsTaken;

        public string[] TestsTaken => testsTaken.Count == 0 ? new string[] { "No tests taken" } : testsTaken.ToArray();

        public Student()
        {
            testsTaken = new List<string>();
        }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            int correctAnswers = CountCorrectAnswers(paper.MarkScheme, answers);
            double percentage = (double)correctAnswers / paper.MarkScheme.Length * 100;
            string result = percentage >= double.Parse(paper.PassMark.TrimEnd('%')) ? "Passed" : "Failed";
            string testResult = $"{paper.Subject}: {result}! ({percentage:F0}%)";
            testsTaken.Add(testResult);
        }

        private int CountCorrectAnswers(string[] markScheme, string[] answers)
        {
            int correctAnswers = 0;
            for (int i = 0; i < Math.Min(markScheme.Length, answers.Length); i++)
            {
                if (markScheme[i] == answers[i])
                {
                    correctAnswers++;
                }
            }
            return correctAnswers;
        }
    }
}