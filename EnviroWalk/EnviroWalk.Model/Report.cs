using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class Report
    {
        public int ReportID { get; set; }
        public int UserID { get; set; }
        public string ReportFarmName { get; set; }
        public DateTime ReportDateTime { get; set; }
        public virtual ICollection<RepQuestion> repQuestions { get; set; }
        public virtual ICollection<RepQuestionAction> repQuestionActions { get; set; }
        public virtual ICollection<RepQuestionCusAction> repQuestionCusActions { get; set; }
    }
 }

