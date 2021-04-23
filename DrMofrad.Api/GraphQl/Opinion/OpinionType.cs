using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DrMofrad.Api.GraphQl.Opinion
{
    public class OpinionType : ObjectType<Model.Opinion>
    {
        protected override void Configure(IObjectTypeDescriptor<Model.Opinion> descriptor)
        {
            descriptor.Description("Faq");
            descriptor.Field(p => p.Article)
                .UseDbContext<DrMofradDbContext>()
                .ResolveWith<Resolver>(resolver => resolver.GetArticle(default!, default!));
        }

        private class Resolver
        {
            public Model.Article GetArticle(Model.Opinion _opinion, [ScopedService] DrMofradDbContext drMofradDbContext)
            {
                return drMofradDbContext.Articles.FirstOrDefault(arti => arti.Id == _opinion.ArticleId);
            }
        }
    }
}