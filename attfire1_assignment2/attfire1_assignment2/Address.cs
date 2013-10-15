using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Address
    {
        [Required]
        [Key]
        public int AddressId { get; set; }
        [Required]
        [MaxLength(100)]
        public string StreetAddress { get; set; }
        [MaxLength(100)]
        public string Suburb { get; set; }
        [Required]
        [MaxLength(35)]
        public string TownOrCity { get; set; }
        [Required]
        [Range(9010, 9598)] // Range based on postcodes in the Dunedin City region
        public int PostCode { get; set; }
        [Required]
        [MaxLength(9), MinLength(9)]
        public string LandlinePhone { get; set; }

        // Reverse navigation
        public virtual ICollection<Person> Person { get; set; } 
    }
}
