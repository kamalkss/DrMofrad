using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.TelegramChannel
{
    public class TelegramChannelType : ObjectType<Model.TelegramChannel>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.TelegramChannel> descriptor)
        {
            descriptor.Description("Telegram Channel");
            descriptor.Field(p => p.DefinerNavigation)
                .ResolveWith<Resolver>(resolver => resolver.GetUser(default!, default))
                .UseDbContext<DrMofradDbContext>();
        }

        private class Resolver
        {
            public Model.TelegramUser GetUser(Model.TelegramChannel _channel,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.TelegramUsers.FirstOrDefault(user => user.Id == _channel.Definer);
            }
        }
    }
}