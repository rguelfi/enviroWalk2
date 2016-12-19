using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class RepQuestionActionModel
    {
        public int ID { get; set; }
        public int QuestionActionID { get; set; }
        public ReportModel Report { get; set; }
        public bool RepQuestionActionAns { get; set; }
        public DateTime RepQuestionActionDate { get; set; }
    }
}
