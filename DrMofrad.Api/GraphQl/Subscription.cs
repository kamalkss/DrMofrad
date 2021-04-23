using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public Model.ActivityCenter OnActivityCenterAdded([EventMessage] Model.ActivityCenter activityCenter)
        {
            return activityCenter;
        }
    }
}
