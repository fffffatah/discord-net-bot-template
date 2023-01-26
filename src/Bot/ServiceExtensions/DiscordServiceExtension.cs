using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.ServiceExtensions
{
    public static class DiscordServiceExtension
    {
        public static IServiceCollection AddDiscordService(this IServiceCollection service)
        {
            service.AddSingleton(new DiscordSocketConfig
            {
                GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.MessageContent | GatewayIntents.GuildMessages | GatewayIntents.GuildMessageReactions | GatewayIntents.GuildMessageTyping
            });
            service.AddSingleton<DiscordSocketClient>();
            service.AddSingleton<CommandService>();

            return service;
        }
    }
}
