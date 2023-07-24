using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pruebalocal.Models;

namespace Pruebalocal.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UserViewModel>> GetAllUsers()
        {
            try
            {
                return await _dbContext.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                // Aquí puedes manejar la excepción, registrarla o devolver un mensaje de error más informativo.
                // Por ejemplo:
                Console.WriteLine($"Error al obtener usuarios: {ex.Message}");
                return new List<UserViewModel>();
            }
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<UserViewModel> GetUserById(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task AddUser(UserViewModel user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUser(UserViewModel user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}