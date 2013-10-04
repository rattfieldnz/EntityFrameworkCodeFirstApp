using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Lesson
    {
        [Required]
        [Key]
        public int LessonId { get; set; }
        [Required]
        public string LessonName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public decimal StudentFee { get; set; }
        [Required]
        public decimal OpenFee { get; set; }
        [Required]
        public short MaxStudents { get; set; }
        [Required]
        public int TutorTutorId { get; set; } 

        // Reverse navigation
        public virtual ICollection<StudentLesson> StudentLesson { get; set; } 

        // Foreign keys
        [Required]
        [ForeignKey("TutorTutorId")]
        public virtual Tutor Tutor { get; set; } 

        public Lesson()
        {
            StudentLesson = new List<StudentLesson>();
        }
    }
}
