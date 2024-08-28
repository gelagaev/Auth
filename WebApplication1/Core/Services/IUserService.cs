using WebApplication1.Core.Models;

namespace WebApplication1.Core.Services;

public interface IUserService
{
    Task<RegisterResponseModel> RegisterAsync(RegisterModel model, CancellationToken ct);
}