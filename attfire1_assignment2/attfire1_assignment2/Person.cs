using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Person
    {
        [Required]
        [Key]
        public int PersonId { get; set; } 
        [Required]
        public string FirstName { get; set; } 
        [Required]
        public string LastName { get; set; } 
        [Required]
        public string StreetAddress { get; set; } 
        public string Suburb { get; set; } 
        [Required]
        public short Postcode { get; set; } 
        public int? EnsembleEnsembleId { get; set; } 

        // Reverse navigation
        //public virtual ICollection<Parent> Parent { get; set; } 
        //public virtual ICollection<PersonSheetMusic> PersonSheetMusic { get; set; } 
        //public virtual ICollection<Student> Student { get; set; } 
        //public virtual ICollection<Tutor> Tutor { get; set; } 

        // Foreign keys
        [ForeignKey("EnsembleEnsembleId")]
        public virtual Ensemble Ensemble { get; set; } 

        public Person()
        {
            //Parent = new List<Parent>();
            //PersonSheetMusic = new List<PersonSheetMusic>();
            //Student = new List<Student>();
            //Tutor = new List<Tutor>();
        }
    }
}
