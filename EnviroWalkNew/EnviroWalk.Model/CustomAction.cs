using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class CustomAction
    {
        [Key, Column(Order = 0)]
        public int CustomAction_Id { get; set; }

        [ForeignKey("Report")]
        public int Report_Id { get; set; }

        [ForeignKey("Question")]
        public int Question_Id { get; set; }

        public int Client_Id { get; set; }
        public string Description { get; set; }
        public bool Answer { get; set; }
        public int Sequence { get; set; }
        public DateTime Date { get; set; }
        public virtual Question Question { get; set; }
        public virtual Report Report { get; set; }

    }
}
