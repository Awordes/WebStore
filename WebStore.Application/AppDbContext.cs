using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;

namespace WebStore.Application;

public abstract class AppDbContext(DbContextOptions options): DbContext(options)
{
    public required DbSet<Product> Products { get; set; }
}
