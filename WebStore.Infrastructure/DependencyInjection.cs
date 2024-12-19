using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebStore.Application;
using WebStore.Infrastructure.DbContexts;
using WebStore.Infrastructure.Exceptions;
using WebStore.Infrastructure.Options;

namespace WebStore.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var postgreDbOptions = configuration.GetSection(PostgreDbOptions.SectionName).Get<PostgreDbOptions>()
            ?? throw new OptionsBindingException(PostgreDbOptions.SectionName);

        services.AddDbContext<PostgreDbContext>(opt =>
        {
            opt.UseNpgsql(postgreDbOptions.ConnectionString, npgsql =>
            {
                npgsql.MigrationsAssembly(typeof(DependencyInjection).Assembly);

                if (postgreDbOptions.PostgreSqlVersion is not null)
                {
                    npgsql.SetPostgresVersion(
                        postgreDbOptions.PostgreSqlVersion.Major,
                        postgreDbOptions.PostgreSqlVersion.Minor
                    );
                }
            });
        });

        services.AddTransient<AppDbContext, PostgreDbContext>();

        return services;
    }
}
