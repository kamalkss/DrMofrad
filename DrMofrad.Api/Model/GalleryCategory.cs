using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Index(nameof(LangId), Name = "IX_LangId")]
    public class GalleryCategory
    {
        public GalleryCategory()
        {
            Galleries = new HashSet<Gallery>();
        }

        [Key] public int Id { get; set; }

        [Required] [StringLength(50)] public string Title { get; set; }

        [Column("imgUrl")]
        [StringLength(1000)]
        public string ImgUrl { get; set; }

        public int? LangId { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("GalleryCategories")]
        public virtual Lang Lang { get; set; }

        [InverseProperty(nameof(Gallery.GalleryCategory))]
        public virtual ICollection<Gallery> Galleries { get; set; }
    }
}