using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mohamed_Shafik_Mohamed_Shafik.Models
{
    public class info_projects
    {
        public  My_info inf { get; set; }
        public ICollection<Projects> projects { get; set; }
    }
}
