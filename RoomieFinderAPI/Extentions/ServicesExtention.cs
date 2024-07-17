using RoomieFinderCore.Contracts.AnswerContracts;
using RoomieFinderCore.Contracts.AuthContracts;
using RoomieFinderCore.Contracts.DormitotyContracts;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Contracts.QuestionContracts;
using RoomieFinderCore.Contracts.RequestContracts;
using RoomieFinderCore.Contracts.RoomContracts;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Services.AnswerService;
using RoomieFinderCore.Services.AuthServices;
using RoomieFinderCore.Services.DormitoryServices;
using RoomieFinderCore.Services.QuestionaireServices;
using RoomieFinderCore.Services.QuestionService;
using RoomieFinderCore.Services.RequestServices;
using RoomieFinderCore.Services.RoomServices;
using RoomieFinderCore.Services.StudentServices;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServicesExtention
{

    public static IServiceCollection AddServices(this IServiceCollection builder)
    {
        builder.AddScoped<IAuthContract, AuthService>();

        builder.AddScoped<IQuestionaireContract, QuestionaireService>();
        builder.AddScoped<IQuestionaireGetContract, QuestionaireGetService>();
        builder.AddScoped<IQuestionaireCheckerContract, QuestionaireCheckerService>();

        builder.AddScoped<IQuestionContract, QuestionService>();
        builder.AddScoped<IQuestionaireCheckerContract, QuestionaireCheckerService>();


        builder.AddScoped<IAnswerContract, AnswerService>();
        builder.AddScoped<IAnswerCheckerContract, AnswerCheckerService>();

        builder.AddScoped<IStudentAnswerContract, StudentAnswerService>();
        builder.AddScoped<IStudentCheckerContract, StudentCheckerService>();
        builder.AddScoped<IStudentContract, StudentService>();

        builder.AddScoped<IRoomContract, RoomService>();
        builder.AddScoped<IRoomCheckerContract, RoomCheckerService>();

        builder.AddScoped<IDormitoryContract, DormitoryService>();

        builder.AddScoped<IRequestContract, RequestService>();
        builder.AddScoped<IRequestCheckerContract, RequestCheckerService>();
        builder.AddScoped<IRequestStatusContract, RequestStatusService>();

        return builder;
    }
}
