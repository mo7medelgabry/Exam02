using Exam02.classes;
using System;
using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {  

            Subject sub = new Subject(1,"C#");
            sub.CreateExam();
            Console.WriteLine("To start The Exam Press y to continue");
             
            char yes = char.Parse(Console.ReadLine());
            if(yes ==  'y' || yes == 'Y') 
            {
                
                sub.SubExam.TypeOfExam();
               
            }else
            {
                Console.WriteLine(" try again");
            }


        }
    }
}
