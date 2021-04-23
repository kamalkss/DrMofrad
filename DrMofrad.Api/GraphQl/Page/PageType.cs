using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.Page
{
    public class PageType : ObjectType<Model.Page>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.Page> descriptor)
        {
            descriptor.Description("Hours Attend");
            descriptor.Field(p => p.Lang)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolver>(resolver => resolver.GetLang(default!, default!));
        }

        private class Resolver
        {
            public Model.Lang GetLang(Model.Page _page, [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(lang => lang.Id == _page.LangId);
            }
        }
    }
}