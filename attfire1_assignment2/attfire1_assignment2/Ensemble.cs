using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Ensemble
    {
        [Required]
        [Key]
        public int EnsembleId { get; set; }
        [Required]
        public string EnsembleName { get; set; }
        [Required]
        public int EnsembleLevel { get; set; }
        public string EnsembleLevelDesc { get; set; }

        [Required]
        public virtual ICollection<Person> Person { get; set; }
        public Ensemble()
        {
            Person = new List<Person>();
        }
    }
}
