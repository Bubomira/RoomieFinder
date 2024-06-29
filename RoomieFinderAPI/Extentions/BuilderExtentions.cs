using RoomieFinderInfrastructure.Data;
using Microsoft.EntityFrameworkCore;
using RoomieFinderInfrastructure.Models;
using Microsoft.AspNetCore.Identity;
using RoomieFinderInfrastructure.UnitOfWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using RoomieFinderCore.Contracts.AuthContracts;
using RoomieFinderCore.Services.AuthServices;

using static RoomieFinderInfrastructure.Constants.ModelConstants.ApplicationUserConstants;


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

        builder.AddIdentity<ApplicationUser, IdentityRole>(opt =>
        {
            opt.SignIn.RequireConfirmedAccount = false;
            opt.Password.RequireNonAlphanumeric = false;
            opt.Password.RequireUppercase = false;
            opt.Password.RequiredLength = PasswordMinLength;
        })
            .AddEntityFrameworkStores<RoomieFinderDbContext>()
            .AddDefaultTokenProviders();

        return builder;
    }

    public static IServiceCollection AddJWT(this IServiceCollection builder, IConfiguration configuration)
    {
        string key = configuration["JWT:Secret"] ?? "";

        builder.AddAuthentication(opt =>
         {
             opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
             opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
             opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
         })
         .AddJwtBearer(opt =>
         {
             opt.SaveToken = true;
             opt.UseSecurityTokenValidators = true;
             opt.TokenValidationParameters = new TokenValidationParameters()
             {
                 IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                 ValidateLifetime = true,
                 ValidateAudience = false,
                 ValidateIssuer = false
             };
         });

        builder.AddScoped<IJWTSContract, JWTService>();

        return builder;
    }

}
