using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model.View
{
    public class ReportView
    {
        public string farmName { get; set; }
        public int userID { get; set; }
        public ICollection<AnswerQuestion> questions { get; set; }
        public ICollection<CustomAction> customActions { get; set; }
    }

    public class AnswerQuestion
    {
        public int questionID { get; set; }
        public ICollection<AnswerAction> actions { get; set; }
    }

    public class AnswerAction
    {
        public int id { get; set; }
        private DateTime _fromDate;
        public string date
        {
            get { return _fromDate.ToString("dd/MM/yyyy"); }
            set { _fromDate = DateTime.Parse(value); }
        }
    }

    public class CustomAction
    {
        public int id { get; set; }
        public string description { get; set; }
        public bool answer { get; set; }
        private DateTime _fromDate;
        public string date
        {
            get { return _fromDate.ToString("dd/MM/yyyy"); }
            set { _fromDate = DateTime.Parse(value); }
        }
        public int questionID { get; set; }
    }


}
