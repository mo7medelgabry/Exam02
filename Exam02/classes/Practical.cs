using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.classes
{
    internal class Practical : Exam
    {
        public Practical(int time , int nQustions):base(time, nQustions) 
        {
            
        }

        public override void TheQuestion()
        {
            QuestionList = new MCQ[NumOfQuestion];
            for(int i = 0; i <NumOfQuestion; i++)
            {
                QuestionList[i] = new MCQ();
                QuestionList[i].AddQ();
            }
        }

        public override void TypeOfExam()
        {
            foreach (var Question in QuestionList)
            {
                Console.WriteLine(Question);

                for (int i = 0; i < Question.AnswerList.Length; i++)
                {

                    Console.WriteLine(Question.AnswerList[i]);
                }
                Console.WriteLine("==============================");

                int user;
                do
                {
                    Console.WriteLine("Enter Your Answer");

                } while (int.TryParse(Console.ReadLine(), out user) && user < 1 || user > 3);

                Question.UserAnswer.AnswerId = user;
                Question.UserAnswer.AnswerText = Question.AnswerList[user - 1].AnswerText;
            }
            Console.Clear();
            Console.WriteLine("The Right Answer is ");
            for (int i = 0;i <NumOfQuestion;i++)
            {
                Console.WriteLine($"The Right Answer Of Question:{i+1} is {QuestionList[i].RightAnswer.AnswerText}");
            }
             

           
        }
    }
}
