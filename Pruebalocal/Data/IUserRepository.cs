using System.Collections.Generic;
using System.Threading.Tasks;
using Pruebalocal.Models;

namespace Pruebalocal.Data
{
    public interface IUserRepository
    {
        Task<List<UserViewModel>> GetAllUsers();
        Task<UserViewModel> GetUserById(int id);
        Task AddUser(UserViewModel user);
        Task UpdateUser(UserViewModel user);
        Task DeleteUser(int id);
    }
}