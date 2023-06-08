
using Salon.Domain.Models;

namespace Salon.Applications.Interfaces;

public interface ICalculationCardService
{
    Task<List<CalculationCard>> GetCalculationList();
    CalculationCard GetCalculationCard(int id);
    Task Create(CalculationCard item);
    Task Update(CalculationCard item);
    Task Delete(int id);
    Task Save();
}
