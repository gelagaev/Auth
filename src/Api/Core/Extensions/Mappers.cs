using Api.Controllers.Dto;
using Api.Core.Models;

namespace Api.Core.Extensions;

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