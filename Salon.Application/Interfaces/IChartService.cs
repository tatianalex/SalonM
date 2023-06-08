
using Salon.Domain.Models;

namespace Salon.Application.Interfaces;

public interface IChartService
{
    Chart GetChart(DateTime date);
    Task Create(DateTime datebegin,DateTime dateend);
    Task Update(Chart item);
    Task Delete(DateTime date);
    Task Save();
}
