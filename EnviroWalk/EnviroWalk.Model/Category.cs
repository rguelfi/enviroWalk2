using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviroWalk.Model
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryDescription { get; set; }
        //public virtual ICollection<Question> questions { get; set; }
    }
}
