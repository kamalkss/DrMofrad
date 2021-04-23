using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.SlideShow
{
    public class SlideShowType : ObjectType<Model.SlideShow>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.SlideShow> descriptor)
        {
            descriptor.Description("SlideShow");
            descriptor.Field(p => p.Lang)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolver>(resolver => resolver.GetLang(default!, default!));
        }

        private class Resolver
        {
            public Model.Lang GetLang(Model.SlideShow _slideShow, [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(lang => lang.Id == _slideShow.LangId);
            }
        }
    }
}