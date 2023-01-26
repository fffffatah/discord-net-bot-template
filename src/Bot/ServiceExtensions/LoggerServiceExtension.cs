using Bot.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.ServiceExtensions
{
    public static class LoggerServiceExtension
    {
        public static IServiceCollection AddLoggerService(this IServiceCollection service)
        {
            service.AddSingleton<LoggerService>();

            return service;
        }
    }
}
