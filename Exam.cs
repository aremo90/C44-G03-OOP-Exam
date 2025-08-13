using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Exam
    {
        public int TimeInMinutes { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam() { }

        public Exam(int time, int numQuestions)
        {
            TimeInMinutes = time;
            NumberOfQuestions = numQuestions;
            Questions = new Question[numQuestions];
        }

        public abstract void ShowExam();
    }
}

