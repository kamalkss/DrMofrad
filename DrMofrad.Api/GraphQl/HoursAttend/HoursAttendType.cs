using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.HoursAttend
{
    public class HoursAttendType : ObjectType<Model.HoursAttend>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.HoursAttend> descriptor)
        {
            descriptor.Description("Hours Attend");
            descriptor.Field(p => p.Lang)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolver>(resolver => resolver.GetLang(default!, default!));
        }

        private class Resolver
        {
            public Model.Lang GetLang(Model.HoursAttend _hoursAttend, [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(lang => lang.Id == _hoursAttend.LangId);
            }
        }
    }
}