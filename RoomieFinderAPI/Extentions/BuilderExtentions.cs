using RoomieFinderInfrastructure.Data;
using Microsoft.EntityFrameworkCore;
using RoomieFinderInfrastructure.Models;
using Microsoft.AspNetCore.Identity;
using RoomieFinderInfrastructure.UnitOfWork;


namespace Microsoft.Extensions.DependencyInjection;

public static class BuilderExtentions
{

    public static IServiceCollection AttachDbContext(this IServiceCollection builder, IConfiguration config)
    {

        string? connectionString = config.GetConnectionString("DefaultConnection");

        builder.AddDbContext<RoomieFinderDbContext>(opt =>
            opt.UseSqlServer(connectionString)
        );

        builder.AddScoped<IUnitOfWork, UnitOfWork>();

        return builder;
    }

    public static IServiceCollection AttachIdentity(this IServiceCollection builder)
    {

        builder.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<RoomieFinderDbContext>()
            .AddDefaultTokenProviders();

        return builder;
    }

}
