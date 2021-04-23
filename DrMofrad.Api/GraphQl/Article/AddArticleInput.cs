using System;

namespace DrMofrad.Api.GraphQl.Article
{
    public record AddArticleInput(string Title, string Description, string ImgUrl, string ImgUrl1, string ImgUrl2, int count, int likecount, DateTime date, int Langid, string summeryDescription, string Tag, int articleCategoryId, int Priority);
}