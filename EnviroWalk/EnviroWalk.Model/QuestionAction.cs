using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class QuestionAction
    {
        public int QuestionActionID { get; set; }
        public string QuestionActionDescription { get; set; }
        public int QuestionActionOrder { get; set; }
        public Question Question { get; set; }
        public virtual ICollection<RepQuestionAction> repQuestionActions { get; set; }
    }
}
