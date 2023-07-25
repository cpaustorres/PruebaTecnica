using System.Collections.Generic;
using System.Threading.Tasks;
using Pruebalocal.Models;

namespace Pruebalocal.Data
{
    public interface IUserRepository
    {
        Task<List<UserViewModel>> GetAllUsersAsync();
        Task<UserViewModel> GetUserByIdAsync(int id);
        Task AddUserAsync(UserViewModel user);
        Task UpdateUserAsync(UserViewModel user);
        Task DeleteUserAsync(int id);
    }
}