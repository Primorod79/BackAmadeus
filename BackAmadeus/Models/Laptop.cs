using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace BackAmadeus.Models
{
    public class Laptop
    {
        public int id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Reference { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Storage { get; set; }

        [Required]
        public string Ram { get; set; }

        [Required]
        public string Processor { get; set; }

        [Required]
        public string Price { get; set; }


    }
}
