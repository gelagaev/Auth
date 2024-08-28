using WebApplication1.Controllers.Dto;
using WebApplication1.Core.Models;

namespace WebApplication1.Core.Extensions;

public static class Mappers
{
    public static RegisterModel ToModel(this RegisterRequestDto dto)
    {
        return new RegisterModel(dto.UserName, dto.Password);
    }

    public static RegisterResponseDto ToDto(this RegisterResponseModel model)
    {
        return new RegisterResponseDto(model.Success, model.ErrorMessage);
    }
}