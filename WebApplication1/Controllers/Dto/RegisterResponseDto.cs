using System.Text.Json.Serialization;

namespace WebApplication1.Controllers.Dto;

public record RegisterResponseDto(
    [property: JsonPropertyName("success")]
    bool Success,
    [property: JsonPropertyName("errorMessage")]
    string? ErrorMessage
);