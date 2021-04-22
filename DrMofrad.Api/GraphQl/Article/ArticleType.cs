using System.Linq;
using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;

namespace DrMofrad.Api.GraphQl.Article
{
    public class ArticleType : ObjectType<Model.Article>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.Article> descriptor)
        {
            descriptor.Description("Articles");
            descriptor.Field(p => p.ArticleCategories)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolver>(p => p.GetArticleCategory(default!, default));
            descriptor.Field(p => p.Lang)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolver>(p => p.GetLang(default!, default!));
        }

        private class Resolver
        {
            public Model.Lang GetLang(Model.Article article, [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(p => p.Id == article.LangId);
            }

            public Model.ArticleCategory GetArticleCategory(Model.Article _article,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.ArticleCategories.FirstOrDefault(p => p.Id == _article.ArticleCategoriesId);
            }
        }
    }
}