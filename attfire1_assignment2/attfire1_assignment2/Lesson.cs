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
        [MaxLength(50)]
        public string LessonName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Location { get; set; }
        [Required]
        [MaxLength(35)]
        public string Subject { get; set; }
        public string Instrument { get; set; }
        [Required]
        public decimal StudentFee { get; set; }
        [Required]
        public decimal OpenFee { get; set; }
        [Required]
        public DateTime LessonDate { get; set; } //http://msdn.microsoft.com/en-us/library/az4se3k1.aspx
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime FinishTime { get; set; }
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
