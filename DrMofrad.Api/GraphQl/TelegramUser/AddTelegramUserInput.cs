namespace DrMofrad.Api.GraphQl.TelegramUser
{
    public record AddTelegramUserInput(string TelegramUserFirstName, string TelegramUserLastName,
        string TelegramUserUsername, string TelegramUserLanguageCode);
    public record UpdateTelegramUserInput(int TelegramUserId,string TelegramUserFirstName, string TelegramUserLastName,
        string TelegramUserUsername, string TelegramUserLanguageCode);

    public record DeleteTelegramUserInput(int TelegramUserId);
}