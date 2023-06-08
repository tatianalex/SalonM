using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Salon.Domain.Enums;

namespace Salon.Domain.Models
{
    public class Record
    {
        public long Id;

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [Required] 
        public EnumRecordStatus Status { get; set; } = EnumRecordStatus.Active;
        public long IdChart { get; set; }
        public Chart Chart { get; set; }
        public long IdService { get; set; }
        public Service Service { get; set; }
        public decimal Amount { get; set; }
        public long IdUser { get; set; }
        public User User { get; set; }
        public  List <Record> Records { get; set; }
        public DateTime Start { get; set; } 
        public DateTime Finish { get; set; } 
     
    }
}