using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class RepQuestionAction
    {
        public int RepQuestionActionID { get; set; }
        public bool RepQuestionActionAns { get; set; }
        public DateTime RepQuestionActionDate { get; set; }
        public Report Report { get; set; }
        public QuestionAction QuestionAction { get; set; }
    }
}
