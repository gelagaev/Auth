using WebApplication1.Controllers.Dto;
using WebApplication1.Core.Models;
using WebApplication1.Core.Services;

namespace WebApplication1.Implementation;

public class UserService : IUserService
{
    public Task<RegisterResponseModel> RegisterAsync(RegisterModel model, CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}