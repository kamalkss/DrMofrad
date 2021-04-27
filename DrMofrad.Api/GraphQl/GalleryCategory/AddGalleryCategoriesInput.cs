namespace DrMofrad.Api.GraphQl.GalleryCategory
{
    public record AddGalleryCategoriesInput(string GalleryCategoryTitle, string GalleryCategoryImgUrl);
    public record UpdateGalleryCategoriesInput(int GalleryCateogryId,string GalleryCategoryTitle, string GalleryCategoryImgUrl);

    public record RemoveGalleryCategoriesInput(int GalleryCateogryId);

}