using System.ComponentModel.DataAnnotations;
using System;

namespace Bridges.Models
{
    public class Bridge
    {
      public int BridgeId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public DateTime DateOfConstruction { get; set; }
        [Required]
        public string Architect { get; set; }
    }
}