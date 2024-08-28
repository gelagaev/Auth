using WebApplication1.Controllers.Dto;
using WebApplication1.Core.Models;

namespace WebApplication1.Core.Services;

public interface IUserService
{
    Task<RegisterResponseModel> RegisterAsync(RegisterModel model, CancellationToken ct);
}