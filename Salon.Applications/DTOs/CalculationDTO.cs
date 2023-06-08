using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Applications.DTOs
{
    public class CalculationDTO
    {
       
        public long Id { get; set; }
     
        public long IdService { get; set; }
      
        public decimal Price { get; set; } 
    }
}