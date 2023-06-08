using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Application.DTOs
{
    public class CalculationCardDTO
    {
        
        public long Id { get; set; }
      
        public long IdService { get; set; }
      
        public long IdMaterial { get; set; }
      
        public decimal Quantity { get; set; } 
    }
}