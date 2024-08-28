using System.Text.Json.Serialization;

namespace Api.Controllers.Dto;

public record RegisterResponseDto(
    [property: JsonPropertyName("success")]
    bool Success,
    [property: JsonPropertyName("errorMessage")]
    string? ErrorMessage
);