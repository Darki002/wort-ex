using Microsoft.Extensions.DependencyInjection;

namespace WortEx.Application;

public static class ServiceProvider
{
    public static IServiceCollection AddWortExApplication(this IServiceCollection services)
    {
        return services;
    }
}