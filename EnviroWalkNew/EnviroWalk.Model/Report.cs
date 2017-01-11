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
        public int Id { get; set; }
        public int UserID { get; set; }
        public string FarmName { get; set; }
        public DateTime Date { get; set; }
        public ICollection<AnswerQuestion> AnswerQuestions { get; set; }
        public ICollection<CustomAction> CustomActions { get; set; }
    }
 }

