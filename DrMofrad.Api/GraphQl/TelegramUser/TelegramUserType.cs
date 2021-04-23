using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.TelegramUser
{
    public class TelegramUserType : ObjectType<Model.TelegramUser>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.TelegramUser> descriptor)
        {
            base.Configure(descriptor);
        }

        private class Resolver
        {
            public IQueryable<Model.TelegramMessage> GeTelegramMessages(Model.TelegramUser _telegramUser,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.TelegramMessages.Where(message => message.FromId == _telegramUser.Id);
            }

            public IQueryable<Model.TelegramChannel> GeTelegramChannels(Model.TelegramUser _telegramUser,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.TelegramChannels.Where(channel => channel.Definer == _telegramUser.Id);
            }
        }
    }
}