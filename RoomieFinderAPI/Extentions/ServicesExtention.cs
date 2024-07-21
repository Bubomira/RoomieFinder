using RoomieFinderCore.Contracts.AnswerSheetContracts;
using RoomieFinderCore.Contracts.AuthContracts;
using RoomieFinderCore.Contracts.DormitotyContracts;
using RoomieFinderCore.Contracts.QualityContracts;
using RoomieFinderCore.Contracts.RequestContracts;
using RoomieFinderCore.Contracts.RoomContracts;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Services.AnswerSheetServices;
using RoomieFinderCore.Services.AuthServices;
using RoomieFinderCore.Services.DormitoryServices;
using RoomieFinderCore.Services.QualityServices;
using RoomieFinderCore.Services.RequestServices;
using RoomieFinderCore.Services.RoomServices;
using RoomieFinderCore.Services.StudentServices;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServicesExtention
{

    public static IServiceCollection AddServices(this IServiceCollection builder)
    {
        builder.AddScoped<IAuthContract, AuthService>();

        builder.AddScoped<IQualityContract, QualityService>();

        builder.AddScoped<IAnswerSheetContract, AnswerSheetService>();

        builder.AddScoped<IStudentCheckerContract, StudentCheckerService>();
        builder.AddScoped<IStudentContract, StudentService>();

        builder.AddScoped<IRoomContract, RoomService>();
        builder.AddScoped<IRoomCheckerContract, RoomCheckerService>();
        builder.AddScoped<IRoomateMatchingContract, RoomateMatchingService>();

        builder.AddScoped<IDormitoryContract, DormitoryService>();

        builder.AddScoped<IRequestContract, RequestService>();
        builder.AddScoped<IRequestCheckerContract, RequestCheckerService>();
        builder.AddScoped<IRequestStatusContract, RequestStatusService>();

        return builder;
    }
}
