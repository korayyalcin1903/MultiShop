using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CargoServices.CargoCustomerServices;
using MultiShop.WebUI.Services.UserIdentityServices;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserIdentityService _userIdentityService;
        private readonly ICargoCustomerService _cargoCustomerDto;

        public UserController(IUserIdentityService userIdentityService, ICargoCustomerService cargoCustomerDto)
        {
            _userIdentityService = userIdentityService;
            _cargoCustomerDto = cargoCustomerDto;
        }

        public async Task<IActionResult> UserList()
        {
            var values = await _userIdentityService.GetAllUserListAsync();
            return View(values);
        }

        public async Task<IActionResult> UserAddressInfo(string id)
        {
            var values = await _cargoCustomerDto.GetByIdCargoCustomerInfoAsync(id);
            return View(values);
        }
    }
}
