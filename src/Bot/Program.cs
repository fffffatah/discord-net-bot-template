using Bot.ServiceExtensions;
using Bot.Services;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Bot
{
    class Program
    {
        static async Task Main(string[] args) => await new Program().MainAsync();

        public async Task MainAsync()
        {
            var host = new HostBuilder()
                .ConfigureServices((services) =>
                {
                    /* Add Your Services Here */
                    services.AddLoggerService();
                    services.AddDiscordService();
                    services.AddCommandService();
                    services.AddMiscService();
                }).Build();

            var client = host.Services.GetRequiredService<DiscordSocketClient>();
            var commandService = host.Services.GetRequiredService<CommandService>();
            var commandHandlingService = host.Services.GetRequiredService<CommandHandlingService>();
            var activity = host.Services.GetRequiredService<IActivity>();
            var loggerService = host.Services.GetRequiredService<LoggerService>();

            /* Initiator  */
            await new Initiator(client, commandService, commandHandlingService, activity, loggerService).InitiateAsync();

            await host.RunAsync();
        }
    }
}