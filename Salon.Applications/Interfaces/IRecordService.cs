
using Salon.Domain.Models;

namespace Salon.Applications.Interfaces;

public interface IRecordService
{
    Task <List<Record?>>GetRecordList(DateTime date);
    Task <List<DateTime?>>GetHoursList(DateTime date);
    Task<Record> GetRecord(int id);
    Task Create(Record item);
    Task Update(Record item);
    Task Delete(int id);
    Task Save();
}