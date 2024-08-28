using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers.Dto;
using WebApplication1.Core.Extensions;
using WebApplication1.Core.Services;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost("Register")]
    public async Task<RegisterResponseDto> Register(
        [FromBody] RegisterRequestDto registerRequestDto,
        CancellationToken ct
    )
    {
        var model = registerRequestDto.ToModel();

        var registerResponseModel = await _userService.RegisterAsync(model, ct);
        
        var registerResponseDto = registerResponseModel.ToDto();

        return registerResponseDto;
    }
}
