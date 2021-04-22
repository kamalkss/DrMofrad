using System.Linq;
using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.GalleryCategory
{
    public class GalleryCategoriesType : ObjectType<Model.GalleryCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.GalleryCategory> descriptor)
        {
            descriptor.Description("Categories For Galleries");
            descriptor.Field(p => p.Galleries)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetGalleries(default!, default!));
            descriptor.Field(p => p.Lang)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetLang(default!, default!));
        }

        private class Resolvers
        {
            public Model.Lang GetLang(Model.GalleryCategory _galleryCategory,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(p => p.Id == _galleryCategory.LangId);
            }

            public IQueryable<Model.Gallery> GetGalleries(Model.GalleryCategory _galleryCategory,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Galleries.Where(p => p.GalleryCategoryId == _galleryCategory.Id);
            }
        }
    }
}