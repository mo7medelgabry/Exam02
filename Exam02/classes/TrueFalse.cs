using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.classes
{
    internal class TrueFalse : Question
    {
        public override string Header { get; set; }

        public TrueFalse()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1,"True");
            AnswerList[1] = new Answer(2,"False");
            
        }


        public override void AddQ()
        {
            
            Console.WriteLine("Enter the Question");
            Body = Console.ReadLine();

            int mark;
            do
            {
                Console.WriteLine("Enter The Mark Of Question");

            } while (!int.TryParse(Console.ReadLine(), out mark));

            Mark = mark;

            int rightAnswer;
            do
            {
                Console.WriteLine("Enter the Number Of Right Answer 1 is T 2 False ");

            } while (int.TryParse(Console.ReadLine(), out rightAnswer) && rightAnswer < 1 || rightAnswer > 2);

            RightAnswer.AnswerId = rightAnswer;
            RightAnswer.AnswerText = AnswerList[rightAnswer - 1].AnswerText;
            Console.Clear();


        }
    }
}
