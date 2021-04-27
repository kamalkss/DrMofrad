namespace DrMofrad.Api.GraphQl.SeoSetting
{
    public record AddSeoSettingInput(string SeoSettingPageName, string SeoSettingTitlePage,
        string SeoSettingKeywordsPage, string SeoSettingDescription, int SeoSettingLangId);
    public record UpdateSeoSettingInput(int SeoSettingId,string SeoSettingPageName, string SeoSettingTitlePage,
        string SeoSettingKeywordsPage, string SeoSettingDescription, int SeoSettingLangId);

    public record DeleteSeoSettingInput(int SeoSettingId);
}