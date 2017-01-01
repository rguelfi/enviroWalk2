using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionDescription { get; set; }
        public Category Category { get; set; }
        //public virtual ICollection<QuestionAction> questionActions { get; set; }
        //public virtual ICollection<RepQuestionCusAction> repQuestionCusActions { get; set; }
        //public virtual ICollection<RepQuestion> repQuestions { get; set; }
    }
}
