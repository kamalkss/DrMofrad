using System.Linq;
using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.Gallery
{
    public class GalleryType : ObjectType<Model.Gallery>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.Gallery> descriptor)
        {
            descriptor.Description("Galleries");
            descriptor.Field(p => p.GalleryCategory)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetGalleryCategories(default!, default!));
            descriptor.Field(p => p.Lang)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetLang(default!, default!));
        }

        private class Resolvers
        {
            public Model.Lang GetLang(Model.Gallery _gallery,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(p => p.Id == _gallery.LangId);
            }

            public Model.GalleryCategory GetGalleryCategories(Model.Gallery _gallery,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.GalleryCategories.FirstOrDefault(p => p.Id == _gallery.GalleryCategoryId);
            }
        }
    }
}