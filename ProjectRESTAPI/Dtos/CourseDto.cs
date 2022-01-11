using System.ComponentModel.DataAnnotations;

namespace ProjectRESTAPI.Dtos
{
    public class CourseDto
    {
        public int CourseID { get; set; }

        public string CourseName { get; set; }

        public int CourseCredits { get; set; }

    }
}
