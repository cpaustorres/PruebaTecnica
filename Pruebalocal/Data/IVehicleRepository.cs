using System.Collections.Generic;
using System.Threading.Tasks;
using Pruebalocal.Models;

namespace Pruebalocal.Data
{
    public interface IVehicleRepository
    {
        Task<List<VehicleViewModel>> GetAllVehicles();
        Task<VehicleViewModel> GetVehicleById(int id);
        Task AddVehicle(VehicleViewModel vehicle);
        Task UpdateVehicle(VehicleViewModel vehicle);
        Task DeleteVehicle(int id);
        Task<List<VehicleViewModel>> GetVehiclesByUserId(int userId);
    }
}