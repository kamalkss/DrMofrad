using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.Faq
{
    public class FaqType : ObjectType<Model.Faq>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.Faq> descriptor)
        {
            descriptor.Description("Faq");
            descriptor.Field(p => p.Lang)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolver>(resolver => resolver.GetLang(default!, default!));
        }

        private class Resolver
        {
            public Model.Lang GetLang(Model.Faq _faq, [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(lang => lang.Id == _faq.LangId);
            }
        }
    }
}