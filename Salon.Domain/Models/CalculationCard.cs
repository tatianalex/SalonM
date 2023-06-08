using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Domain.Models
{
    public class CalculationCard
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public long IdService { get; set; }
        public Service Service { get; set; }
        public long IdMaterial { get; set; }
        public Material Material { get; set; } 
        public decimal Quantity { get; set; } 
    }
}