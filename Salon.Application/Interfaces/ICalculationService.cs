

using Salon.Domain.Models;

namespace Salon.Application.Interfaces;

public interface ICalculationService
{

     Task<List<Calculation>> GetCalculationList();
    Calculation GetCalculation(int id);
    Task Create(Calculation item);
    Task Update(Calculation item);
    Task Delete(int id);
    Task Save();
}
