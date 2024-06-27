using RoomieFinderCore.Contracts.AuthContracts;
using RoomieFinderCore.Services.AuthServices;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServicesExtention
{

    public static IServiceCollection AddServices(this IServiceCollection builder)
    {
        builder.AddScoped<IAuthContract, AuthService>();

        return builder;
    }
}
