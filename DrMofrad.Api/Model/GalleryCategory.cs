using System;
using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class GalleryCategory
    {
        public GalleryCategory()
        {
            Galleries = new HashSet<Gallery>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public int? LangId { get; set; }

        public virtual Lang Lang { get; set; }
        public virtual ICollection<Gallery> Galleries { get; set; }
    }
}
