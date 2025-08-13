using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion() { }

        public MCQQuestion(string header, string body, int mark, Answer[] answers) : base(header, body, mark)
        {
            Answers = answers;
        }

        public override bool CheckAnswer(int answerId)
        {
            return answerId == RightAnswerId;
        }
    }
}
