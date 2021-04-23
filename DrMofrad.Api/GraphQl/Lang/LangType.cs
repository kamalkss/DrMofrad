using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

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
            descriptor.Field(p => p.Faqs)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetFaqs(default!, default!));
            descriptor.Field(p => p.Articles)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetArticles(default!, default!));
            descriptor.Field(p => p.ArticleCategories)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetArticleCategories(default!, default!));
            descriptor.Field(p => p.ActivityCenters)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetActivityCenters(default!, default!));
            descriptor.Field(p => p.Clinics)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetClinics(default!, default!));
            descriptor.Field(p => p.SlideShows)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetSlideShows(default!, default!));
            descriptor.Field(p => p.SeoSettings)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetSeoSettings(default!, default!));
            descriptor.Field(p => p.Pages)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetPages(default!, default!));
            descriptor.Field(p => p.HoursAttends)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolvers>(p => p.GetHoursAttends(default!, default!));
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

            public IQueryable<Model.Faq> GetFaqs(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Faqs.Where(p => p.LangId == _lang.Id);
            }

            public IQueryable<Model.ActivityCenter> GetActivityCenters(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.ActivityCenters.Where(p => p.LangId == _lang.Id);
            }

            public IQueryable<Model.Clinic> GetClinics(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Clinics.Where(p => p.LangId == _lang.Id);
            }

            public IQueryable<Model.SlideShow> GetSlideShows(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.SlideShows.Where(p => p.LangId == _lang.Id);
            }

            public IQueryable<Model.SeoSetting> GetSeoSettings(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.SeoSettings.Where(p => p.LangId == _lang.Id);
            }

            public IQueryable<Model.HoursAttend> GetHoursAttends(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.HoursAttends.Where(p => p.LangId == _lang.Id);
            }

            public IQueryable<Model.Article> GetArticles(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Articles.Where(p => p.LangId == _lang.Id);
            }

            public IQueryable<Model.ArticleCategory> GetArticleCategories(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.ArticleCategories.Where(p => p.LangId == _lang.Id);
            }

            public IQueryable<Model.Page> GetPages(Model.Lang _lang,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Pages.Where(p => p.LangId == _lang.Id);
            }
        }
    }
}