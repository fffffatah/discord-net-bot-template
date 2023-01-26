using Bot.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.ServiceExtensions
{
    public static class CommandServiceExtension
    {
        public static IServiceCollection AddCommandService(this IServiceCollection service)
        {
            service.AddSingleton<CommandHandlingService>();
            service.AddSingleton<HttpClient>();

            return service;
        }
    }
}
