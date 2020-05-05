using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mohamed_Shafik_Mohamed_Shafik.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name  { get; set; }
       
    }
    public class My_info:Parent
    {
        
        public string education { get; set; }
        public string job  { get; set; }
       
    }
    public class Projects : Parent
    {
        public string url { get; set; }
        public string Discription { get; set; }
    }
}
