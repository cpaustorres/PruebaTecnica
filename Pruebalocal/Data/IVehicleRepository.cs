using System.Collections.Generic;
using System.Threading.Tasks;
using Pruebalocal.Models;

namespace Pruebalocal.Data
{
    public interface IVehicleRepository
    {
        Task<List<VehicleViewModel>> GetAllVehiclesAsync();
        Task<VehicleViewModel> GetVehicleByIdAsync(int id);
        Task AddVehicleAsync(VehicleViewModel vehicle);
        Task UpdateVehicleAsync(VehicleViewModel vehicle);
        Task DeleteVehicleAsync(int id);
        Task<List<VehicleViewModel>> GetVehiclesByUserIdAsync(int userId);
    }
}