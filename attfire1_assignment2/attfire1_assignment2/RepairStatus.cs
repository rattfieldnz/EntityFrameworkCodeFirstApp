using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class RepairStatus
    {
        [Required]
        [Key]
        public int RepairStatusId { get; set; }
        [Required]
        [MaxLength(35)]
        public string StatusName { get; set; }
        [Required]
        [MaxLength(200)]
        public string StatusDescription { get; set; }

        //Reverse navigation
        public virtual ICollection<Instrument> Instrument { get; set; }

        public RepairStatus()
        {
            Instrument = new List<Instrument>();
        }
    }
}
