using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class AnswerQuestion
    {
        [Key, Column(Order = 0), ForeignKey("Question")]
        public int  Question_Id { get; set; }

        [Key, Column(Order = 1), ForeignKey("Report")]
        public int  Report_Id { get; set; }

        public ICollection<AnswerAction> AnswerActions { get; set;}
        public DateTime Date { get; set; }
        public virtual Question Question { get; set; }
        public virtual Report Report { get; set; }
    }
}

