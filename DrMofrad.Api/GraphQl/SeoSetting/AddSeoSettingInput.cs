namespace DrMofrad.Api.GraphQl.SeoSetting
{
    public record AddSeoSettingInput(string SeoSettingPageName, string SeoSettingTitlePage,
        string SeoSettingKeywordsPage, string SeoSettingDescription, int SeoSettingLangId);
}