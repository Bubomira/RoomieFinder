using RoomieFinderInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection;

public static class BuilderExtentions
{

    public static IServiceCollection AttachDbContext(this IServiceCollection builder, IConfiguration config )
    {

        string connectionString = config.GetConnectionString("DefaultConnection")?? "";

        builder.AddDbContext<RoomieFinderDbContext>(opt =>
        {
            opt.UseSqlServer(connectionString);
        });

        return builder;
    }
}
