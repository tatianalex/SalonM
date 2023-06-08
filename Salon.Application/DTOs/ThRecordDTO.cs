using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salon.Application.DTOs
{
    public class ThRecordDTO
    {
       
        public long ID { get; set; }
     
        public long IdRecord { get; set; }
      
        public long IdMaterial { get; set; }
      
        public decimal Amount { get; set; }
        public decimal Quantity { get; set; }
    }
}