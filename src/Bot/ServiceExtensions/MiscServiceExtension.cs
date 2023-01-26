using Bot.Models;
using Bot.Services;
using Discord;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.ServiceExtensions
{
    public static class MiscServiceExtension
    {
        public static IServiceCollection AddMiscService(this IServiceCollection service)
        {
            service.AddSingleton<PictureService>();
            service.AddSingleton<IActivity, Activity>(x =>
            {
                return new Activity
                {
                    Name = "!help",
                    Type = ActivityType.Listening,
                    Details = "Use Command '!help' to Get Started",
                    Flags = ActivityProperties.None
                };
            });

            return service;
        }
    }
}
