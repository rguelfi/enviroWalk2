using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class RepQuestion
    {
        public int RepQuestionID { get; set; }
        public bool RepQuestionAnswer { get; set; }
        public Report Report { get; set; }
        public Question Question { get; set; }
    }
}

