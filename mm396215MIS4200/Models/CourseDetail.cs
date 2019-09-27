using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mm396215MIS4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }
        public int courseDescription { get; set; }

        public decimal textbookPrice { get; set; }

        public int courseID { get; set; }
        public virtual Course Courses { get; set; }

        public int professorID { get; set; }
        public virtual Professor Professors { get; set; }

    }
}