using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaPodst.Models
{
    public class Warzywo
    {
        /*// I sposób
        public int Id { get; set; }
        // II sposób
        public int WarzywoId { get; set; }
        // III sposób
        [Key]
        public int WarzywId { get; set; }
        */
        public int WarzywoId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
