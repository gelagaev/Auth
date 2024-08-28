using System.ComponentModel.DataAnnotations;
using WebApplication1.Core.Constants;

namespace WebApplication1.Core.Entities;

public sealed class UserEntity
{
    [Key]
    public Guid Id { get; init; }
    [MaxLength(ModelValidationConstants.UserNameMaxLength)]
    public string UserName { get; set; } = string.Empty;
    [MaxLength(ModelValidationConstants.PasswordMaxLength)]
    public string PasswordHash { get; set; } = string.Empty;
}