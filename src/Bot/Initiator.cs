using Bot.Helpers;
using Bot.Services;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Bot
{
    public class Initiator
    {
        DiscordSocketClient _client;
        CommandService _commandService;
        CommandHandlingService _commandHandlingService;
        IActivity _activity;
        LoggerService _loggerService;

        public Initiator(DiscordSocketClient client, CommandService commandService,
            CommandHandlingService commandHandlingService, IActivity activity, LoggerService loggerService)
        {
            _client = client;
            _commandService = commandService;
            _commandHandlingService = commandHandlingService;
            _activity = activity;
            _loggerService = loggerService;
        }

        public async Task InitiateAsync()
        {
            _client.Log += _loggerService.LogAsync;
            _commandService.Log += _loggerService.LogAsync;

            await _commandHandlingService.InitializeAsync();

            await _client.LoginAsync(TokenType.Bot, ConfigurationHelper.GetToken());
            await _client.StartAsync();
            await _client.SetActivityAsync(_activity);

            await Task.Delay(Timeout.Infinite);
        }
    }
}
