namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examType = InputHelper.ReadInt("Choose Exam Type (1: Final, 2: Practical): ");

            int time = InputHelper.ReadInt("Enter Exam Time in minutes: ");

            int numQuestions = InputHelper.ReadInt("Enter number of questions: ");

            Exam exam;
            if (examType == 1)
                exam = new FinalExam(time, numQuestions);
            else
                exam = new PracticalExam(time, numQuestions);

            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write($"\nEnter Question {i + 1} Header:");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body:");
                string body = Console.ReadLine();

                int mark = InputHelper.ReadInt("Enter Question Mark:");

                int qType = InputHelper.ReadInt("Choose Question Type (1- MCQ, 2- True/False):");


                Question q;
                if (qType == 1)
                {
                    int ansCount = InputHelper.ReadInt("Enter number of answers: ");
                    Answer[] answers = new Answer[ansCount];

                    for (int j = 0; j < ansCount; j++)
                    {
                        Console.Write($"Answer {j + 1} text: ");
                        answers[j] = new Answer(j + 1, Console.ReadLine());
                    }

                    q = new MCQQuestion(header, body, mark, answers);
                }
                else
                {
                    q = new TrueFalseQuestion(header, body, mark);
                }

                q.RightAnswerId = InputHelper.ReadInt("Enter the correct answer ID: ");

                exam.Questions[i] = q;
            }

            Subject subject = new Subject(1, "OOP");
            subject.CreateExam(exam);

            Console.WriteLine("\n--- Exam Started ---");
            subject.SubjectExam.ShowExam();
        }
    }
}
