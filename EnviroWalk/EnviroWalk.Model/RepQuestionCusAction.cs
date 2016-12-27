using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class RepQuestionCusAction
    {
        public int RepQuestionCusActionID { get; set; }
        public bool RepQuestionCusActionAns { get; set; }
        public DateTime RepQuestionCusActionDate { get; set; }
        public string RepQuestionCusActionDescription { get; set; }
        public int RepQuestionCusActionOrder { get; set; }
        public Report Report { get; set; }
        public Question Question { get; set; }
    }
}
