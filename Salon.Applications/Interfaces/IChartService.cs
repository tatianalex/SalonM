
using Salon.Domain.Models;

namespace Salon.Applications.Interfaces;

public interface IChartService
{
    Chart GetChart(DateTime date);
    Task Create(DateTime datebegin,DateTime dateend);
    Task Update(Chart item);
    Task Delete(DateTime date);
    Task Save();
}
