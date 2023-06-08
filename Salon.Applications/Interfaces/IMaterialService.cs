using Salon.Applications.DTOs;
using Salon.Domain.Models;

namespace Salon.Applications.Interfaces;

public interface IMaterialService
{
    Task<List<Material?>> GetMaterialList();
    Task<Material> GetMaterial(int id);
    Task Create(MaterialDTO item);
    Task Update(MaterialDTO item);
    Task Delete(int id);
    Task Save();
}
