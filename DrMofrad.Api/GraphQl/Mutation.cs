using DrMofrad.Api.GraphQl.ActivityCenter;
using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Subscriptions;
using System.Threading;
using System.Threading.Tasks;

namespace DrMofrad.Api.GraphQl
{
    public class Mutation
    {
        [UseDbContext(typeof(DrMofradDbContext))]
        public async Task<AddActivityCenterPayLoad> AddActivityCenterAsync(
            AddActivityCenterInput input,
            [ScopedService] DrMofradDbContext drMofradDbContext,
            [Service] ITopicEventSender eventSender,
            CancellationToken cancellationToken
        )
        {
            var ActivityCenter = new Model.ActivityCenter
            {
                Title = input.Title,
                LangId = input.ActivityCenterLangId,
                MoreInfo = input.MoreInfo
            };
            drMofradDbContext.ActivityCenters.Add(ActivityCenter);
            await drMofradDbContext.SaveChangesAsync(cancellationToken);
            await eventSender.SendAsync(nameof(Subscription.OnActivityCenterAdded), ActivityCenter, cancellationToken);
            return new AddActivityCenterPayLoad(ActivityCenter);
        }

        public async Task<AddActivityCenterPayLoad> RemoveActivityCenter(
            RemoveActivityCenterInput remove,
            [ScopedService] DrMofradDbContext drMofradDbContext,
            [Service] ITopicEventSender eventSender,
            CancellationToken cancellationToken)
        {
            var activityCenter = new Model.ActivityCenter() {Id = remove.ActivityCenterId};
            drMofradDbContext.ActivityCenters.Remove(activityCenter);
            await drMofradDbContext.SaveChangesAsync(cancellationToken);
            await eventSender.SendAsync(nameof(Subscription.OnActivityCenterAdded), activityCenter, cancellationToken);
            return new AddActivityCenterPayLoad(activityCenter);
        }
    }
}