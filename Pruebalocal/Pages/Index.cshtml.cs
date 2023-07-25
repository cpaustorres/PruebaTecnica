using Microsoft.AspNetCore.Mvc.RazorPages;
using Pruebalocal.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Pruebalocal.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Pruebalocal.Data;

namespace Pruebalocal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUserRepository _userRepository;

        public IndexModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Properties
        public int SelectedUserId { get; set; }
        public List<SelectListItem> UserSelectList { get; set; }
        public List<UserViewModel> Users { get; set; }
        public UserViewModel UserViewModel { get; set; }
        public VehicleViewModel VehiclesViewModel { get; set; }

        // Page Initialization
        public async Task OnGet()
        {
            await LoadData();
        }

        // Private Methods
        private async Task LoadData()
        {
            Users = await _userRepository.GetAllUsersAsync();
            InitializeUserSelectList();
            UserViewModel = Users?.Count > 0 ? Users[0] : null;
        }

        private void InitializeUserSelectList()
        {
            UserSelectList = Users?.Select(user => new SelectListItem { Value = user.Id.ToString(), Text = user.Nombre }).ToList() ?? new List<SelectListItem>();
        }
    }
}