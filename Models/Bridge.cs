using System.ComponentModel.DataAnnotations;
using System;

namespace Architecture.Models
{
    public class Bridge
    {
      public int BridgeId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime DateOfConstruction { get; set; }
        public string Architect { get; set; }
    }
}