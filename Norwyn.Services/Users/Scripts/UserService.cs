using Norwyn.Infrastructure.Repositories;

namespace Norwyn.Services.Users.Scripts;

public class UserService(IRepository repository) : IUserService
{
    private readonly IRepository _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    
}