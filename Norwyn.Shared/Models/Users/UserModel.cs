using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Norwyn.Shared.Models.Users;

[Table("Users")]
public class UserModel
{
    [Key]

    public long ID { get; set; } //Primary key
 
    public string UserName { get; set; }
    
    public string Password { get; set; }
    
    public string Email { get; set; }
    
}