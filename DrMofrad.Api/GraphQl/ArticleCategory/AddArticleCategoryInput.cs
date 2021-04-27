namespace DrMofrad.Api.GraphQl.Member
{
    public record AddArticleCategoryCenterInput(string ArticleCategoryTitle, string ArticleCategoryImgUrl,
        int ArticleCategoryLangId);
    public record UpdateArticleCategoryCenterInput(int ArticleCategoryId,string ArticleCategoryTitle, string ArticleCategoryImgUrl,
        int ArticleCategoryLangId);

    public record RemoveArticleCategoryCenterInput(int ArticleCategoryId);
}