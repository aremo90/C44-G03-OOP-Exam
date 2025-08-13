using System;

namespace ConsoleApp1
{
    internal class PracticalExam : Exam
    {
        public PracticalExam() { }

        public PracticalExam(int time, int numQuestions) : base(time, numQuestions) { }

        public override void ShowExam()
        {
            int totalScore = 0;
            Console.WriteLine("Practical Exam:");

            foreach (var q in Questions)
            {
                Console.WriteLine($"\n{q.Header}\n{q.Body}");
                foreach (var ans in q.Answers)
                {
                    Console.WriteLine(ans);
                }

                int choice = InputHelper.ReadInt("Your Answer: ");

                if (q.CheckAnswer(choice))
                {
                    Console.WriteLine("Correct!");
                    totalScore += q.Mark;
                }
                else
                {
                    Console.WriteLine($"Wrong! Correct answer: {q.RightAnswerId}");
                }
            }

            Console.WriteLine($"\nYour Grade: {totalScore}");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
