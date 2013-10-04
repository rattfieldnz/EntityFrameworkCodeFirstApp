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
        [Key]
        public int LessonId { get; set; } 
        public string LessonName { get; set; } 
        public string Location { get; set; } 
        public string Subject { get; set; }
        public decimal StudentFee { get; set; }
        public decimal OpenFee { get; set; }
        public short MaxStudents { get; set; } 
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
