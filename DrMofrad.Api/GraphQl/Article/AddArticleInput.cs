using System;

namespace DrMofrad.Api.GraphQl.Article
{
    public record AddArticleInput(string ArticleTitle, string ArticleDescription, string ArticleImgUrl,
        string ArticleImgUrl1, string ArticleImgUrl2, int Articlecount, int Articlelikecount, DateTime Articledate,
        int ArticleLangid, string ArticlesummeryDescription, string ArticleTag, int ArticlearticleCategoryId,
        int ArticlePriority);
}