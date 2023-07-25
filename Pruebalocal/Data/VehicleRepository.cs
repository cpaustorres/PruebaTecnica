using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pruebalocal.Models;

namespace Pruebalocal.Data
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly AppDbContext _dbContext;

        public VehicleRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<VehicleViewModel>> GetAllVehiclesAsync()
        {
            try
            {
                return await _dbContext.Vehicles.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener vehículos: {ex.Message}");
                return new List<VehicleViewModel>();
            }
        }

        public async Task<VehicleViewModel> GetVehicleByIdAsync(int id)
        {
            return await _dbContext.Vehicles.FindAsync(id);
        }

        public async Task<List<VehicleViewModel>> GetVehiclesByUserIdAsync(int userId)
        {
            return await _dbContext.Vehicles.Where(v => v.UsuarioId == userId).ToListAsync();
        }

        public async Task AddVehicleAsync(VehicleViewModel vehicle)
        {
            _dbContext.Vehicles.Add(vehicle);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateVehicleAsync(VehicleViewModel vehicle)
        {
            _dbContext.Entry(vehicle).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteVehicleAsync(int id)
        {
            var vehicle = await _dbContext.Vehicles.FindAsync(id);
            if (vehicle != null)
            {
                _dbContext.Vehicles.Remove(vehicle);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}