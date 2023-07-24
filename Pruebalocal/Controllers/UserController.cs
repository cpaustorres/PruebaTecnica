using Microsoft.AspNetCore.Mvc;
using Pruebalocal.Data;
using Pruebalocal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pruebalocal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetAllUsers()
        {
            // Aquí implementa la lógica para obtener todos los usuarios desde tu base de datos
            // El método GetAllUsers() del IUserRepository puede manejar la obtención de los usuarios
            List<UserViewModel> users = await _userRepository.GetAllUsers();

            if (users == null || users.Count == 0)
            {
                return NoContent(); // Devuelve un resultado 204 No Content si no se encontraron usuarios
            }

            return Ok(users);
        }
    }
}