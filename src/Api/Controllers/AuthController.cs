using Api.Controllers.Dto;
using Api.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Api.Core.Extensions;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost("Register")]
    [ProducesResponseType(typeof(ActionResult<RegisterResponseDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<RegisterResponseDto>> RegisterAsync(
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
