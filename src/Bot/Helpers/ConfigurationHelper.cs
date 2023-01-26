namespace Bot.Helpers
{
    public static class ConfigurationHelper
    {
        /// <summary>
        /// Get your Discord Bot Token from Environemnt Variable
        /// "DISCORD_BOT_TOKEN"
        /// </summary>
        /// <returns>Token</returns>
        public static string GetToken()
        {
            return Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");
        }
    }
}
