using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.Cilinic
{
    public class CilinicType : ObjectType<Clinic>
    {
        protected override void Configure(IObjectTypeDescriptor<Clinic> descriptor)
        {
            descriptor.Description("Clinics");
            descriptor.Field(clinic => clinic.Lang)
                .ResolveWith<Resolver>(resolver => resolver.GetLang(default!, default!))
                .UseDbContext<DrMofradDbContext>();
        }

        private class Resolver
        {
            public Model.Lang GetLang(Clinic _clinic, [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(lang => lang.Id == _clinic.LangId);
            }
        }
    }
}