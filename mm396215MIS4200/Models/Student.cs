using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mm396215MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public ICollection<Course> Course { get; set; }


    }
}