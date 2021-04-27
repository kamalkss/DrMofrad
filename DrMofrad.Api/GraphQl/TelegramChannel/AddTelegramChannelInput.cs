namespace DrMofrad.Api.GraphQl.TelegramChannel
{
    public record AddTelegramChannelInput(string TelegramChannelUserName, string TelegramChannelDefiner);
    public record UpdateTelegramChannelInput(string TelegramChannelUserName, string TelegramChannelDefiner);

    public record DeleteTelegramChannelInput(int TelegramChannelUserName);
}