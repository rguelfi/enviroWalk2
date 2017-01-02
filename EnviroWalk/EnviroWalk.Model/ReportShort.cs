using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class ReportShort
    {
        public int userID { get; set; }
        public string farmName { get; set; }
        public virtual IEnumerable<QuestionShort> questions { get; set; }
        public virtual IEnumerable<CusActionShort> customactions { get; set; }
    }

    public class QuestionShort
    {
        public int questionID { get; set; }
        public virtual IEnumerable<ActionShort> actions { get; set; }
    }

    public class ActionShort
    {
        public int id { get; set; }
        public DateTime date { get; set; }
    }

    public class CusActionShort
    {
        public int id { get; set; }
        public int questionID { get; set; }
        public string description { get; set; }
        public bool answer { get; set; }
        public DateTime date { get; set; }
    }
}
