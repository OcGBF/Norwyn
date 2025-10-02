using Norwyn.Shared.Models.Users;
using System.Threading.Tasks;

namespace Norwyn.Services.Account
{
    public interface IAccountService
    {
        Task<bool> RegisterUserAsync(UserModel user);
    }
}