
using Salon.Application.DTOs;
using Salon.Domain.Models;

namespace Salon.Application.Interfaces;

public interface IMaterialService
{
    Task<List<Material?>> GetMaterialList();
    Task<Material> GetMaterial(int id);
    Task Create(MaterialDTO item);
    Task Update(MaterialDTO item);
    Task Delete(int id);
    Task Save();
}
