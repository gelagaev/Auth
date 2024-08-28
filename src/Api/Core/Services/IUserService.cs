using Api.Core.Models;

namespace Api.Core.Services;

public interface IUserService
{
    Task<RegisterResponseModel> RegisterAsync(RegisterModel model, CancellationToken ct);
}