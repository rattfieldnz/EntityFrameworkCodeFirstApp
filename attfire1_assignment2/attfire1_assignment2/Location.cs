using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Location
    {
        [Required]
        [Key]
        public int LocationId { get; set; } 
        [Required]
        public string LocationName { get; set; } 

        // Reverse navigation
        public virtual ICollection<Performance> Performance { get; set; } 

        public Location()
        {
            Performance = new List<Performance>();
        }
    }
}
