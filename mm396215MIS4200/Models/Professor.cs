using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mm396215MIS4200.Models
{
    public class Professor
    {
        public int professorID { get; set; }
        public string professorName { get; set; }
        public string professorEmail { get; set; }


        public ICollection<CourseDetail> CourseDetails { get; set; }
    }
}