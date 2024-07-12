using RoomieFinderCore.Contracts.AnswerContracts;
using RoomieFinderCore.Contracts.AuthContracts;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Contracts.QuestionContracts;
using RoomieFinderCore.Services.AnswerService;
using RoomieFinderCore.Services.AuthServices;
using RoomieFinderCore.Services.QuestionaireServices;
using RoomieFinderCore.Services.QuestionService;

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

        return builder;
    }
}
