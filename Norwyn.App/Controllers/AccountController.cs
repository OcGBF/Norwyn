using Microsoft.AspNetCore.Mvc;
using Norwyn.App.Models;
using Norwyn.Services.Account;
using Norwyn.Shared.Models.Users;

namespace Norwyn.App.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new UserModel
                {
                    Email = model.Email,
                    Password = model.Password,
                    UserName = model.FullName
                };

                var success = await _accountService.RegisterUserAsync(user);
                if (success) model.ShowMessage = true;
            }

            return View(model);
        }
    }
}