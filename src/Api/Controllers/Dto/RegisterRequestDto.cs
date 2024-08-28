using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Api.Core.Constants;

namespace Api.Controllers.Dto;

public record RegisterRequestDto(
    [MaxLength(ModelValidationConstants.UserNameMaxLength, ErrorMessage = ModelValidationConstants.UserNameMaxLengthErrorMessage)]
    [property: JsonPropertyName("userName")]
    string UserName,
    [MaxLength(ModelValidationConstants.PasswordMaxLength)]
    [property: JsonPropertyName("password")]
    string Password
);