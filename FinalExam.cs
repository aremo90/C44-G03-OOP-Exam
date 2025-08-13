using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FinalExam : Exam
    {
        public FinalExam() { }

        public FinalExam(int time, int numQuestions) : base(time, numQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:");
            int totalScore = 0;

            foreach (var q in Questions)
            {
                Console.WriteLine($"\n{q.Header}\n{q.Body}");
                foreach (var ans in q.Answers)
                {
                    Console.WriteLine(ans);
                }

                int choice = InputHelper.ReadInt("Your Answer: ");
                if (q.CheckAnswer(choice))
                    totalScore += q.Mark;
            }

            Console.WriteLine($"\nYour Grade: {totalScore}");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}


