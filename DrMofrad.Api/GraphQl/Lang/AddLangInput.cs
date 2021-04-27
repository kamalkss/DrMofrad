namespace DrMofrad.Api.GraphQl.Lang
{
    public record AddLangInput(string LangTitle);
    public record UpdateLangInput(int LangId,string LangTitle);
    public record DeleteLangInput(int LangId);
}