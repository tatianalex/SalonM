
using Salon.Domain.Models;

namespace Salon.Application.Interfaces;

public interface IServiceService
{
    Task<List<Service>> GetServiceList();
    Task<Service> GetService(int id);
    Task Create(Service item);
    Task Update(Service item);
    Task Delete(int id);
    Task Save();
}
