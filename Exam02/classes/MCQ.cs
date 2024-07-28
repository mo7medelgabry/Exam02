using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.classes
{
    internal class MCQ : Question
    {
        public override string Header {get; set;}

        public MCQ()
        {
            AnswerList = new Answer[3];
            

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

            Console.WriteLine("Enter Choices");

            for (int i = 0; i < 3; i++) {

                AnswerList[i] = new Answer()
                {
                    AnswerId = i + 1
                };
                Console.WriteLine($"Enter Choice Number {i + 1}");
                AnswerList[i].AnswerText = Console.ReadLine(); 
            }
            int rightAnswer;
            do
            {
                Console.WriteLine("Enter the Number Of Right Answer");

            } while (int.TryParse(Console.ReadLine(), out rightAnswer)  && rightAnswer<1 || rightAnswer > 3 );

            RightAnswer.AnswerId = rightAnswer;
            RightAnswer.AnswerText = AnswerList[rightAnswer - 1].AnswerText;
            Console.Clear();

        }
    }

}

   

