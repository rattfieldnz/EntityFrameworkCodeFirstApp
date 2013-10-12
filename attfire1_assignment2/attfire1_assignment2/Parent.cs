using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Parent
    {
        [Key]
        public int ParentId { get; set; } 
        public int PersonPersonId { get; set; } 
        public int? SpouseParentId { get; set; } 

        // Reverse navigation
        public virtual ICollection<Parent> Parent2 { get; set; } 
        public virtual ICollection<Student> Student { get; set; } 

        // Foreign keys
        [Required]
        [ForeignKey("PersonPersonId")]
        public virtual Person Person { get; set; }
        [Required]
        [ForeignKey("SpouseParentId")]
        public virtual Parent Parent1 { get; set; } 

        public Parent()
        {
            Parent2 = new List<Parent>();
            Student = new List<Student>();
        }
    }
}
