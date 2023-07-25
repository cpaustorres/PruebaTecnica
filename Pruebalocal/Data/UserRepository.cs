using System;
using System.Collections.Generic;
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

        public async Task<List<UserViewModel>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<UserViewModel> GetUserByIdAsync(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task AddUserAsync(UserViewModel user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(UserViewModel user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
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