namespace DrMofrad.Api.GraphQl.Page
{
    public record AddPageInput(string PageTitle, string PageDescription, int PageLangId, string PageKey);
    public record UpdatePageInput(int PageId,string PageTitle, string PageDescription, int PageLangId, string PageKey);

    public record DeletePageInput(int PageId);
}