using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class RepQuestionModel
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public ReportModel Report { get; set; }
        public bool RepQuestionAnswer { get; set; }
        
    }
}

