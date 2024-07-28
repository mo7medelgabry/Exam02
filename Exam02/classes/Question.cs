using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.classes
{
    internal abstract class Question
    {
        public abstract string Header { get; set; }
        public string Body { get; set; }
        public int Mark {  get; set; }
        public Answer[]  AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }
        
        
        public Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }

        public abstract void AddQ();

        public override string ToString()
        {
            return $"{Header}   Mark {Mark} \n {Body} ";
        }


    }
}
