using System;

namespace DrMofrad.Api.GraphQl.Gallery
{
    public record AddGalleryInput(string GalleryTitle, string GalleryimgUrl, string GalleryImgUrl1,
        string GalleryImgUrl2, int GalleryCategoriesId, DateTime Gallerydate, int GalleryLangId); 
    public record UpdateGalleryInput(int GalleryId,string GalleryTitle, string GalleryimgUrl, string GalleryImgUrl1,
         string GalleryImgUrl2, int GalleryCategoriesId, DateTime Gallerydate, int GalleryLangId);

    public record RemoveGalleryInput(int GalleryId);
}