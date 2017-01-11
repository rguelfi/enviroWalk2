using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class AnswerAction
    {
        [Key, Column(Order = 0), ForeignKey("QuestionAction")]
        public int  QuestionAction_Id { get; set; }

        [Key, Column(Order = 1), ForeignKey("AnswerQuestion")]
        public int Question_Id { get; set; }

        [Key, Column(Order = 2), ForeignKey("AnswerQuestion")]
        public int Report_Id { get; set; }

        public DateTime Date { get; set; }

        public virtual QuestionAction QuestionAction { get; set; }
        public virtual AnswerQuestion AnswerQuestion { get; set; }
    }
}
