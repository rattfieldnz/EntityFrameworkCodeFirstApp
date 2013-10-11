using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    class Address
    {
        [Required]
        [Key]
        public int AddressId { get; set; }
        [Required]
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        [Required]
        public string TownOrCity { get; set; }
        [Required]
        public int PostCode { get; set; }
        [Required]
        [MaxLength(9), MinLength(9)]
        public string LandlinePhone { get; set; }

        // Reverse navigation
        public virtual ICollection<Person> Person { get; set; } 
    }
}
