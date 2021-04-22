using System.Linq;
using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

namespace DrMofrad.Api.GraphQl.ArticleCategory
{
    public class ArticleCategoryType:ObjectType<Model.ArticleCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.ArticleCategory> descriptor)
        {
            descriptor.Description("Article Categories");
        }

        private class Resolver
        {
            public Model.Lang GetLang(Model.ArticleCategory _articleCategory,
                [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Langs.FirstOrDefault(lang => lang.Id == _articleCategory.LangId);
            }
        }
    }
}