using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class ReportExportView
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public IEnumerable<QuestionAction> QuestionActions { get; set; }
        public Report Report { get; set; }
    }
}
