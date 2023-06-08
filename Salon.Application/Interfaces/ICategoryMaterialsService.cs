

using Salon.Domain.Models;

namespace Salon.Application.Interfaces;

public interface ICategoryMaterialsService
{
    Task<List<CategoryMaterials>> GetCategoryMaterialsList();
    Task<CategoryMaterials> GetCategoryMaterials(int id);
    Task Create(string name, string description);
    Task Update(CategoryMaterials item);
    Task Delete(long id);
    Task Save();
}
