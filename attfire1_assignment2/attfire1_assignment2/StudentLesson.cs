using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class StudentLesson
    {
        [Required]
        [Key, Column(Order = 1)]
        public int StudentStudentId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public int LessonLessonId { get; set; } 

        // Foreign keys
        [Required]
        [ForeignKey("StudentStudentId")]
        public virtual Student Student { get; set; }
        [Required]
        [ForeignKey("LessonLessonId")]
        public virtual Lesson Lesson { get; set; } 
    }
}
