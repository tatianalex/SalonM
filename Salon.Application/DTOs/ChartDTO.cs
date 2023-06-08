using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Application.DTOs
{
    public class ChartDTO
    {
      
        public long ID { get; set; }
        
        public DateTime Date { get; set; } 
        public DateTime Start { get; set; } 
        public DateTime Finish { get; set; } 

    }
}