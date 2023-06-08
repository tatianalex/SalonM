

using Salon.Domain.Models;

namespace Salon.Application.Interfaces;

public interface ICategoryServiceService
{
    Task<List<CategoryService>> GetCategoryServiceList();
    CategoryService GetCategoryServiceService(int id);
    Task Create(CategoryService item);
    Task Update(CategoryService item);
    Task Delete(int id);
    Task Save();
}
