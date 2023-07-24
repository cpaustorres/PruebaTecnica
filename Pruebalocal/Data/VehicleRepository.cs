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

        public async Task<List<VehicleViewModel>> GetAllVehicles()
        {
            try
            {
                return await _dbContext.Vehicles.ToListAsync();
            }
            catch (Exception ex)
            {
                // Aquí puedes manejar la excepción, registrarla o devolver un mensaje de error más informativo.
                // Por ejemplo:
                Console.WriteLine($"Error al obtener vehículos: {ex.Message}");
                return new List<VehicleViewModel>();
            }
        }

        public async Task<VehicleViewModel> GetVehicleById(int id)
        {
            return await _dbContext.Vehicles.FindAsync(id);
        }

        public async Task<List<VehicleViewModel>> GetVehiclesByUserId(int userId)
        {
            return await _dbContext.Vehicles.Where(v => v.UsuarioId == userId).ToListAsync();
        }

        public async Task AddVehicle(VehicleViewModel vehicle)
        {
            _dbContext.Vehicles.Add(vehicle);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateVehicle(VehicleViewModel vehicle)
        {
            _dbContext.Entry(vehicle).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteVehicle(int id)
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