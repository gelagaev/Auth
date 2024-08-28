using Microsoft.EntityFrameworkCore;
using WebApplication1.Core.Entities;

namespace WebApplication1.Infrastructure;

public sealed class AppDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
}