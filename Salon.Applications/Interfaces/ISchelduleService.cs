
using Salon.Domain.Models;

namespace Salon.Applications.Interfaces;

public interface ISchelduleService
{
    IEnumerable<Scheldule> GetSchelduleList();
    Scheldule GetScheldule (EnumsWeek day);
    Task Create(Scheldule item);
    Task Update(Scheldule item);
    Task Delete(EnumsWeek day);
    Task Save();
}
