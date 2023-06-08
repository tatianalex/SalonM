using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Salon.Applications.DTOs
{
    public class SchelduleDTO
    {
       // [Key] public EnumsWeek Role { get; set; } = EnumsWeek.Sunday;
       public DayOfWeek Day { get; set; } = DayOfWeek.Sunday;
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        

    }
}