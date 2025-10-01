using Microsoft.AspNetCore.Mvc;
using Norwyn.Shared.Models.Users;

namespace Norwyn.App.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    //     [HttpPost]
    //     public IActionResult Login(UserModel model)
    //     {
    //         if (ModelState.IsValid)
    //         {
    //             if (model.Email == "admin@example.com" && model.Password == "password123")
    //             {
    //                 // Redirect to home on success
    //                 return RedirectToAction("Index", "Home");
    //             }
    //
    //             // Add error if login fails
    //             ModelState.AddModelError("", "Invalid login attempt");
    //         }
    //
    //         return View("Index", model);
    //     }
     }
}