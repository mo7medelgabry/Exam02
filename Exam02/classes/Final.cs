using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.classes
{
    internal class Final : Exam
    {
        public Final(int time, int nQuestion) :base(time,nQuestion) 
        {
            
        }



        public override void TheQuestion()
        {
         QuestionList = new Question[NumOfQuestion];

            for (int i = 0; i < NumOfQuestion; i++) {

                Console.WriteLine("select question for exam (1 MCQ) (2 T or F)");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You chose a Multiple Choice question.");

                        break;

                    case 2:
                        Console.WriteLine("You chose a True/False question.");

                        break;

                    default:
                        Console.WriteLine("Invalid Selection.");
                        break;
                }

                if (choice == 1)
                {
                    QuestionList[i] = new MCQ();
                    QuestionList[i].AddQ();

                }
                else if (choice == 2){ 
                 
                    QuestionList[i] = new TrueFalse();
                    QuestionList[i].AddQ();
                
                }



            }  

        }

           public override void TypeOfExam()
        {
            foreach(var Question in QuestionList )
            {
                Console.WriteLine(Question);

                for (int i = 0; i < Question.AnswerList.Length; i++) {

                    Console.WriteLine(Question.AnswerList[i]);
                }
                Console.WriteLine("==============================");

                int user;
                do
                {
                    Console.WriteLine("Enter Your Answer");

                } while (int.TryParse(Console.ReadLine(), out user) && user < 1 || user > 3);

                Question.UserAnswer.AnswerId = user;
                Question.UserAnswer.AnswerText = Question.AnswerList[user-1].AnswerText;
            }
            Console.Clear(); 

            int TotalMark =0;
            int Grade = 0;
            for(int i = 0;i < QuestionList.Length;i++)
            {
                TotalMark += QuestionList[i].Mark;
                if(QuestionList[i].RightAnswer.AnswerId == QuestionList[i].UserAnswer.AnswerId)
                {
                    Grade += QuestionList[i].Mark;
                }
                Console.WriteLine( QuestionList[i].Body );
                Console.WriteLine(QuestionList[i].UserAnswer.AnswerText);
            } 
             


            Console.WriteLine($"Your Grade Is {Grade}");
        }
    }
}
