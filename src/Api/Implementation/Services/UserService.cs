using Api.Core.Entities;
using Api.Core.Models;
using Api.Core.Services;
using Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Api.Implementation.Services;

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
        //TODO Implement
        return input;
    }
}