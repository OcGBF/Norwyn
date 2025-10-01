using System.ComponentModel.DataAnnotations;

namespace Norwyn.App.Models;

public class CityRollsViewModel
{
    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string Password  { get; set; }

    public string? SelectedRole { get; set; }

}