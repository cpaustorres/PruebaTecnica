using Microsoft.AspNetCore.Mvc;
using Pruebalocal.Models;

namespace Pruebalocal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiUserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Aquí puedes agregar la lógica para obtener los datos de la tabla Usuarios y retornarlos en formato JSON
            // Por ejemplo, puedes usar Entity Framework Core para acceder a la base de datos y obtener los datos

            var users = new List<UserViewModel>
            {
                new UserViewModel { Id = 1, Nombre = "John", Apellidos = "Doe", Dni = "12345678A", Carnet = "B", Telefono = "123456789" },
                new UserViewModel { Id = 2, Nombre = "Jane", Apellidos = "Smith", Dni = "98765432Z", Carnet = "B", Telefono = "987654321" }
                // Agrega más usuarios si es necesario
            };

            return Ok(users);
        }
    }
}