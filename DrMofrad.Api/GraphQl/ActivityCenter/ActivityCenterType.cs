using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.ActivityCenter
{
    public class ActivityCenterType : ObjectType<Model.ActivityCenter>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.ActivityCenter> descriptor)
        {
            descriptor.Description("Activity Center");
            descriptor.Field(p => p.Lang)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetLang(default!, default!));
        }

        private class Resolvers
        {
            public Model.Lang GetLang(Model.ActivityCenter _ActivityCenter,
                [ScopedService] DrMofradDbContext drmofradDbContext)
            {
                return drmofradDbContext.Langs.FirstOrDefault(p => p.Id == _ActivityCenter.LangId);
            }
        }
    }
}