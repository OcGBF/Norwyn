using Microsoft.AspNetCore.Mvc;
using Norwyn.App.Models;


namespace Norwyn.App.Controllers
{
    
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignUp(SignUpViewModel model)
        {
            if (model.ShowMessage)
            {
                return View();
            }
            model.ShowMessage = true;
            return View(model);
        }
        
        // [HttpPost]
        // public IActionResult Login(LoginViewModel model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         if (model.Email == "test@norwyn.com" && model.Password == "P@55w0rd")
        //         {
        //             return RedirectToAction("Index", "Home");
        //         }
        //
        //         // ModelState.AddModelError("", "You cant fool me HAHAHAHAHAHAHAHAHAHAHAHAHAHAHA");
        //     }
        //
        //     return View(model);
        // }
    }
}