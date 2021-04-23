using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.TelegramMessage
{
    public class TelegramMessageType : ObjectType<Model.TelegramMessage>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.TelegramMessage> descriptor)
        {
            descriptor.Description("Telegram Message");
            descriptor.Field(p => p.From)
                .ResolveWith<Resolver>(resolver => resolver.GetUser(default!, default))
                .UseDbContext<DrMofradDbContext>();
        }

        private class Resolver
        {
            public Model.TelegramUser GetUser(Model.TelegramMessage _telegramMessage,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.TelegramUsers.FirstOrDefault(user => user.Id == _telegramMessage.FromId);
            }
        }
    }
}