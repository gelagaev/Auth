using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;

namespace WebApplication1;

[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("Register")]
    public Task<RegisterResponseDto> Register(
        [FromBody] RegisterRequestDto registerRequestDto,
        CancellationToken ct
    )
    {

    }
}
