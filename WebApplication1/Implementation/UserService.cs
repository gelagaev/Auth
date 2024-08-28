using Microsoft.EntityFrameworkCore;
using WebApplication1.Controllers.Dto;
using WebApplication1.Core.Entities;
using WebApplication1.Core.Models;
using WebApplication1.Core.Services;
using WebApplication1.Infrastructure;

namespace WebApplication1.Implementation;

public class UserService : IUserService
{
    private readonly AppDbContext _appDbContext;

    public UserService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<RegisterResponseModel> RegisterAsync(RegisterModel model, CancellationToken ct)
    {
        var userExist = await _appDbContext
            .Users
            .AnyAsync(x => x.UserName.ToLower() == model.UserName.ToLower(), ct);

        if (userExist)
        {
            return new RegisterResponseModel(false, "Username already taken");
        }

        var passwordHash = CreateMd5(model.Password);

        var user = new UserEntity
        {
            Id = Guid.NewGuid(),
            UserName = model.UserName,
            PasswordHash = passwordHash
        };

        await _appDbContext.Users.AddAsync(user, ct);
        await _appDbContext.SaveChangesAsync(ct);

        return new RegisterResponseModel(true, null);
    }
    
    private static string CreateMd5(string input)
    {
        return input;
    }
}