using Microsoft.Extensions.DependencyInjection;

namespace WortEx.Infrastructure;

public static class ServiceProvider
{
    public static IServiceCollection AddWortExInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}