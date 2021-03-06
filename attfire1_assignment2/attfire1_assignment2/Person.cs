﻿using System;
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
        [MaxLength(50)]
        public string FirstName { get; set; } 
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string EmailAddress { get; set; }
        [MaxLength(10)]
        public string MobileNumber { get; set; }
        public int EnsembleEnsembleId { get; set; }
        [Required]
        public int AddressAddressId { get; set; }

        // Reverse navigation
        public virtual ICollection<Student> Student { get; set; } 
        public virtual ICollection<Tutor> Tutor { get; set; } 

        // Foreign keys
        [ForeignKey("EnsembleEnsembleId")]
        public virtual Ensemble Ensemble { get; set; }
        [ForeignKey("AddressAddressId")]
        public virtual Address Address { get; set; }

        public Person()
        {
            Student = new List<Student>();
            Tutor = new List<Tutor>();
        }
    }
}
