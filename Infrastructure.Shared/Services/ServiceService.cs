
using Microsoft.EntityFrameworkCore;
using Salon.Application;
using Salon.Application.Enums;
using Salon.Application.Interfaces;
using Salon.Domain;
using Salon.Domain.Models;


namespace Infrastructure.Shared.Services;

public class ServiceService : IServiceService
{
    private readonly AplicationContext _db;

    public ServiceService(AplicationContext db, Service service)
    {
        _db = db;
       
    }

    public Task<List<Service>> GetServiceList()
    {
        return _db.Services.ToListAsync();
    }

    async Task<Service> IServiceService.GetService(int id)
    {
        Service service = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
        return service;
    }

    async Task IServiceService.Create(Service item)
    {
        await _db.AddAsync(item);
        await _db.SaveChangesAsync();
    }

    public async Task Update(Service item)
    {
        _db.Update(item);

    }


    public async Task Save()
    {

        await _db.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {


        var service = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
        if (service is null)

            throw new SalonException("Service is not exists!", EnumErrorCode.EntityIsNotFound);

        _db.Services.Remove(service);
        await _db.SaveChangesAsync();
    }
}


  