using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class ReportModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string ReportFarmName { get; set; }
        public DateTime ReportDateTime { get; set; }
        public virtual ICollection<RepQuestionModel> repQuestions { get; set; }
        public virtual ICollection<RepQuestionActionModel> repQuestionActions { get; set; }
        public virtual ICollection<RepQuestionCusActionModel> repQuestionCusActions { get; set; }

    }
 }

