namespace DrMofrad.Api.GraphQl.TelegramMessage
{
    public record AddTelegramMessageInput(string TelegramMessageMessage_text, string TelegramMessageResponse,
        string TelegramMessageshowinpublic, string TelegramMessageMessage_time, string TelegramMessageResponse_time,
        int TelegramMessageFrom_Id);
    public record UpdateTelegramMessageInput(int TelegramMessageId,string TelegramMessageMessage_text, string TelegramMessageResponse,
        string TelegramMessageshowinpublic, string TelegramMessageMessage_time, string TelegramMessageResponse_time,
        int TelegramMessageFrom_Id);

    public record DeleteTelegramMessageInput(int TelegramMessageId);
}