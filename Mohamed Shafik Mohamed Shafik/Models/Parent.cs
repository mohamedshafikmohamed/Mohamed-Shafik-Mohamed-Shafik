using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mohamed_Shafik_Mohamed_Shafik.Models
{
    public class Parent
    {
        public Guid Id { get; set; }
        public string Name  { get; set; }
        public string image { get; set; }
    }
    public class My_info:Parent
    {
     
        public string job  { get; set; }
    }
    public class Projects : Parent
    {

        public string Discription { get; set; }
    }
}
