using System;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class Gallery
    {
        public int Id { get; set; }
        public int GalleryCategoryId { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string ImgUrlOne { get; set; }
        public string ImgUrlTwo { get; set; }
        public DateTime? Date { get; set; }
        public int? LangId { get; set; }

        public virtual GalleryCategory GalleryCategory { get; set; }
        public virtual Lang Lang { get; set; }
    }
}