using System.Linq;
using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.Lang
{
    public class LangType : ObjectType<Model.Lang>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.Lang> descriptor)
        {
            descriptor.Description("Language");
            descriptor.Field(p => p.GalleryCategories)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(resolvers => resolvers.GetGalleryCategory(default!, default!));
            descriptor.Field(p => p.Galleries)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetGalleries(default!, default!));
        }

        private class Resolvers
        {
            public IQueryable<Model.GalleryCategory> GetGalleryCategory(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.GalleryCategories.Where(p => p.LangId == _lang.Id);
            }

            public IQueryable<Model.Gallery> GetGalleries(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Galleries.Where(p => p.LangId == _lang.Id);
            }
        }
    }
}