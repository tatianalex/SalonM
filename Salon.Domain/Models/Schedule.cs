using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Salon.Domain.Models
{
    public class Scheldule
    {
       // [Key] public EnumsWeek Role { get; set; } = EnumsWeek.Sunday;
       [Key] public DayOfWeek Day { get; set; } = DayOfWeek.Sunday;
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        

    }
}