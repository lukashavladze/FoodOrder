using FoodOrder.Repositories.Infrastructure;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.Web.Controllers
{
    public class AccountController1 : Controller
    {
        IAuthenticationRepository _authRepository;

        public AccountController1(IAuthenticationRepository AuthRepository)
        {
            _authRepository = AuthRepository;
        }
        
        public IActionResult Login()
        {
            return View();
        }
    }
}
