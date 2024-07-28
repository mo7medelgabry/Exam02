using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.classes
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumOfQuestion { get; set; }
        public Question[] QuestionList  { get; set; }

        public Exam(int time, int nQuestion)
        {
            Time = time;
            NumOfQuestion = nQuestion; 
            
        }

        public abstract void TheQuestion();
        public abstract void TypeOfExam();
    }
}
