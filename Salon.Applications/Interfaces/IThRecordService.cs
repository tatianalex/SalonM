
using Salon.Domain.Models;

namespace Salon.Applications.Interfaces;

public interface IThRecordService
{
    Task <ThRecord> GetThRecordList();
    ThRecord GetThRecord(int id);
    Task Create(ThRecord item);
    Task Update(ThRecord item);
    Task Delete(int id);
    Task Save();
}
