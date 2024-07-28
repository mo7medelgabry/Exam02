using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.classes
{
    internal class Subject
    {
        public int SubId { get; set; }
        public string SubName { get; set; }
        public Exam SubExam  { get; set; }

        public Subject(int subid , string subname)
        {
            subid = SubId  ;
            SubName = subname;
        } 

        public void CreateExam()
        {
            int type;
            int time;
            int NumOfQuestion;
            do
            {
                Console.WriteLine("Choose Type Of Exam (1 for Practical / 2 for Final) "); 
         
            }while(!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 2);

            do
            {
                Console.WriteLine("Enter Time Of Exam ");

            } while (!int.TryParse(Console.ReadLine(), out time)) ;


          do
            {
                Console.WriteLine("Enter Number Of Question For Exam"); 
         
            }while(!int.TryParse(Console.ReadLine(), out NumOfQuestion ));

            if(type == 1)
            {
                SubExam = new Practical(time,NumOfQuestion);
            }
            else
            {
                SubExam = new Final(time,NumOfQuestion);
            } 
            Console.Clear();
            SubExam.TheQuestion();

    }
    }

}
