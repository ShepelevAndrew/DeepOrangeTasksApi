using DeepOrangeTasks.Application.Common.Interfaces.BlobStorage;
using DeepOrangeTasks.Application.Common.Services;
using DeepOrangeTasks.Infrastructure.BlobStorage;
using DeepOrangeTasks.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeepOrangeTasks.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<BlobStorageSettings>(configuration.GetSection(BlobStorageSettings.SectionName));

        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IBlobStorageService, BlobStorageService>();

        return services;
    }
}