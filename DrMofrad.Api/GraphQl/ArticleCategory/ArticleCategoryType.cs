using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.ArticleCategory
{
    public class ArticleCategoryType : ObjectType<Model.ArticleCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.ArticleCategory> descriptor)
        {
            descriptor.Description("Article Categories");
            descriptor.Field(p => p.Articles)
                .ResolveWith<Resolver>(resolver => resolver.GetArticles(default!, default!))
                .UseDbContext<DrMofradDbContext>();
            descriptor.Field(p => p.Lang)
                .ResolveWith<Resolver>(resolver => resolver.GetLang(default!, default!))
                .UseDbContext<DrMofradDbContext>();
        }

        private class Resolver
        {
            public Model.Lang GetLang(Model.ArticleCategory _articleCategory,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(lang => lang.Id == _articleCategory.LangId);
            }

            public IQueryable<Model.Article> GetArticles(Model.ArticleCategory _articleCategory,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Articles.Where(article =>
                    article.ArticleCategoriesId == _articleCategory.Id);
            }
        }
    }
}