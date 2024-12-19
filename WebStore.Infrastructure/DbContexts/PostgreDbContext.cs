using Microsoft.EntityFrameworkCore;
using WebStore.Application;

namespace WebStore.Infrastructure.DbContexts;

public class PostgreDbContext(DbContextOptions options) : AppDbContext(options)
{
}
