namespace DrMofrad.Api.GraphQl.TelegramUser
{
    public record AddTelegramUserInput(string TelegramUserFirstName, string TelegramUserLastName,
        string TelegramUserUsername, string TelegramUserLanguageCode);
}