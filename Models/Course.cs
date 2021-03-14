using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    {
        // built in helpers, affects the code they are on top of (Course ID)
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        // declaration of courseID, Title and credits.
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
