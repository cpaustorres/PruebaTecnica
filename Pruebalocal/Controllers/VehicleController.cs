using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pruebalocal.Data;
using Pruebalocal.Models;

namespace Pruebalocal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<VehicleViewModel>> GetAllVehicles()
        //{
        //    return Ok(_vehicles);
        //}

        //[HttpGet("{id}")]
        //public ActionResult<VehicleViewModel> GetVehicleById(int id)
        //{
        //    var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
        //    if (vehicle == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(vehicle);
        //}

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<VehicleViewModel>>> GetVehiclesByUserId(int userId)
        {
            List<VehicleViewModel> vehicles = await _vehicleRepository.GetVehiclesByUserId(userId);

            if (vehicles == null || vehicles.Count == 0)
            {
                return NoContent(); // Devuelve un resultado 204 No Content si no se encontraron usuarios
            }

            return Ok(vehicles);

        }

        //[HttpPost]
        //public ActionResult<VehicleViewModel> CreateVehicle(VehicleViewModel vehicle)
        //{
        //    // Aquí podrías agregar la lógica para crear un nuevo vehículo en la lista _vehicles
        //    // y devolver el vehículo creado.
        //    // Por simplicidad, este ejemplo no incluye la lógica de creación.

        //    // Simplemente devolvemos el vehículo que recibimos en el body de la solicitud.
        //    return Ok(vehicle);
        //}

        //[HttpPut("{id}")]
        //public ActionResult<VehicleViewModel> UpdateVehicle(int id, VehicleViewModel updatedVehicle)
        //{
        //    var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
        //    if (vehicle == null)
        //    {
        //        return NotFound();
        //    }

        //    // Aquí podrías agregar la lógica para actualizar los datos del vehículo con los datos
        //    // proporcionados en updatedVehicle.
        //    // Por simplicidad, este ejemplo no incluye la lógica de actualización.

        //    // Simplemente devolvemos el vehículo actualizado con los datos proporcionados en el body de la solicitud.
        //    return Ok(updatedVehicle);
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteVehicle(int id)
        //{
        //    var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
        //    if (vehicle == null)
        //    {
        //        return NotFound();
        //    }

        //    // Aquí podrías agregar la lógica para eliminar el vehículo con el ID proporcionado.
        //    // Por simplicidad, este ejemplo no incluye la lógica de eliminación.

        //    // Simplemente devolvemos un resultado exitoso si el vehículo fue encontrado y se "eliminó".
        //    return NoContent();
        //}
    }
}