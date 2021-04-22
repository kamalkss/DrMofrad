using System.Linq;
using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.Cilinic
{
    public class CilinicType : ObjectType<Model.Clinic>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.Clinic> descriptor)
        {
            descriptor.Description("Clinics");
            descriptor.Field(clinic => clinic.Lang)
                .ResolveWith<Resolver>(resolver => resolver.GetLang(default!, default!))
                .UseDbContext<DrMofradDbContext>();
        }
        private class Resolver
        {
            public Model.Lang GetLang(Model.Clinic _clinic, [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(lang => lang.Id == _clinic.LangId);
            }
        }
    }
}