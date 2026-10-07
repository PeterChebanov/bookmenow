using Microsoft.Extensions.DependencyInjection;

namespace BookIt.CoreApi.Application.Health;

public static class HealthServiceCollectionExtensions
{
    public static IServiceCollection AddHealth(this IServiceCollection services)
    {
        services.AddScoped<ILivenessService, LivenessService>();
        return services;
    }
}