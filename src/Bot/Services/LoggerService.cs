using Discord;

namespace Bot.Services
{
    public class LoggerService
    {
        public Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());

            return Task.CompletedTask;
        }
    }
}
