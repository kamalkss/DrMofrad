using System;

namespace DrMofrad.Api.GraphQl.Gallery
{
    public record AddGalleryInput(string Title,string imgUrl,string ImgUrl1,string ImgUrl2,int GalleryCategoriesId,DateTime Gallerydate,int GalleryLangId);
}