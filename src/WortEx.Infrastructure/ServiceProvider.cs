using Microsoft.Extensions.DependencyInjection;
using WortEx.Infrastructure.Database.Context;

namespace WortEx.Infrastructure;

public static class ServiceProvider
{
    public static IServiceCollection AddWortExInfrastructure(this IServiceCollection services)
    {
        return services.AddDbContextFactory<MessageContext>();
    }
}