using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public  Category Category { get; set; }
    }
}
