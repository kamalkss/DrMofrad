namespace DrMofrad.Api.GraphQl.Opinion
{
    public record AddOpinionInput(int OpinionArticleId, string OpinionFullName, string OpinionEmail);
    public record UpdateOpinionInput(int OpinionId,int OpinionArticleId, string OpinionFullName, string OpinionEmail);

    public record DeleteOpinionInput(int OpinionId);
}