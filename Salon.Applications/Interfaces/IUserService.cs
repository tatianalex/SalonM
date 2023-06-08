
using Salon.Domain.Models;


namespace Salon.Applications.Interfaces;

public interface IUserService
{
    Task<User> Add(string login, string Supername, string Name, string Phone, string pas1,string pas2);

    Task<SearchUserResponse> SearchUser(UserGetModel model);

    Task Update(long id, string Supername, string Name, string Phone, string pas1,string pas2);
    Task DeleteUserAsync(long id);

}

