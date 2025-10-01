using System.ComponentModel.DataAnnotations;

namespace Norwyn.App.Models;

public record LoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    public bool RememberMe { get; set; }
    
    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }

    
}