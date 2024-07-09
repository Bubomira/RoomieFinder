using RoomieFinderCore.Contracts.AuthContracts;
using RoomieFinderCore.Contracts.QuestionaireContracts;

using RoomieFinderCore.Services.AuthServices;
using RoomieFinderCore.Services.QuestionaireServices;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServicesExtention
{

    public static IServiceCollection AddServices(this IServiceCollection builder)
    {
        builder.AddScoped<IAuthContract, AuthService>();

        builder.AddScoped<IQuestionaireContract, QuestionaireService>();
        builder.AddScoped<IQuestionContract, QuestionService>();
        builder.AddScoped<IAnswerContract, AnswerService>();

        return builder;
    }
}
