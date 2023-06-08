using Microsoft.EntityFrameworkCore;
using Salon.Application;
using Salon.Application.Enums;
using Salon.Application.Interfaces;
using Salon.Domain;
using Salon.Domain.Models;


namespace Infrastructure.Shared.Services;

public class CategoryServiceService : ICategoryServiceService
{
    private readonly AplicationContext _db;

    public CategoryServiceService(AplicationContext db)
    {
        _db = db;
    }
 
    public Task<List<CategoryService>> GetCategoryServiceList()
    {
        return _db.CategoryService.ToListAsync();
    }

    public CategoryService GetCategoryServiceService(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<CategoryService> GetCategoryService(int id)
    {
        CategoryService categoryService = await _db.CategoryService.FirstOrDefaultAsync(x => x.Id == id);
        return categoryService;
    }

    public async Task Create(CategoryService item)
    {
        await _db.AddAsync(item);
        await _db.SaveChangesAsync();
    }

    public async Task Update(CategoryService item)
    {

        _db.Update(item);
        await _db.SaveChangesAsync();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public async Task Delete(long id)
    {


        var categoryService = await _db.CategoryService.FirstOrDefaultAsync(x => x != null && x.Id == id);
        if (categoryService is null)

            throw new SalonException("Category Service is not exists!", EnumErrorCode.EntityIsNotFound);

        _db.CategoryService.Remove(categoryService);
        await _db.SaveChangesAsync();
    }

}

   

   

    