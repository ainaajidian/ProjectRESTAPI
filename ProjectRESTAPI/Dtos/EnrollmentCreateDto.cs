using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectRESTAPI.Dtos
{
    public class EnrollmentCreateDto
    {
        [Required]
        public int CourseId { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public string Grade { get; set; }
    }
}
