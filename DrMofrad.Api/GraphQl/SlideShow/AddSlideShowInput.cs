namespace DrMofrad.Api.GraphQl.SlideShow
{
    public record AddSlideShowInput(string SlideShowTitle, string SlideShowDescription, string SlideShowImgUrl,
        int SlideShowOrders, int SlideShowLangId);
    public record UpdateSlideShowInput(int SlideShowId,string SlideShowTitle, string SlideShowDescription, string SlideShowImgUrl,
        int SlideShowOrders, int SlideShowLangId);

    public record DeleteSlideShowInput(int SlideShowId);
}