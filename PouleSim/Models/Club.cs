using System;
using System.ComponentModel.DataAnnotations;

namespace PouleSim.Models
{
    public class Club
    {
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9][a-zA-Z0-9'\s]*[a-zA-Z0-9]$")]
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Range(60, 100)]
        public int Powerlevel { get; set; }
    }
}
