using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Domain.Models
{
    public class Calculation
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public long IdService { get; set; }
        public Service Service { get; set; }
        public decimal Price { get; set; } 
    }
}