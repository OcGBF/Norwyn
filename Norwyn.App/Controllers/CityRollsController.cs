using Microsoft.AspNetCore.Mvc;
using Norwyn.App.Models;
using Norwyn.Services.Users.Scripts;

namespace Norwyn.App.Controllers
{
    public class CityRollsController : Controller
    {
    //     private readonly ICityRollsService _cityRollsService;
    //
    //     public CityRollsController(ICityRollsService cityRollsService)
    //     {
    //         _cityRollsService = cityRollsService;
    //     }
    //
    [HttpGet]
    public IActionResult CityRolls()
    {
        return View();
    }
    //
    //     [HttpPost]
    //     public IActionResult CityRollsLogin(CityRollsViewModel model)
    //     {
    //         if (ModelState.IsValid)
    //         {
    //             
    //             _cityRollsService.ProcessCityRolls(model);
    //
    //             ViewBag.Message = $"Data submitted for {model.Username} with role {model.SelectedRole}";
    //             return View("CityRolls", model);
    //         }
    //
    //         return View("CityRolls", model);
    //     }
     }
}