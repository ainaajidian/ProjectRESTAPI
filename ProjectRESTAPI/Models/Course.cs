using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectRESTAPI.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        [Required]
        [MaxLength(100)]
        public string CourseName { get; set; }

        [Required]
        public int CourseCredits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
