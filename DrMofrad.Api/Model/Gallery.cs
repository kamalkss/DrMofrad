using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class Gallery
    {
        [Key] public int Id { get; set; }

        public int GalleryCategoryId { get; set; }

        [Required] [StringLength(50)] public string Title { get; set; }

        [Column("imgUrl")]
        [StringLength(1000)]
        public string ImgUrl { get; set; }

        [Column("imgUrlOne")]
        [StringLength(1000)]
        public string ImgUrlOne { get; set; }

        [Column("imgUrlTwo")]
        [StringLength(1000)]
        public string ImgUrlTwo { get; set; }

        [Column(TypeName = "datetime")] public DateTime? Date { get; set; }

        public int? LangId { get; set; }

        [ForeignKey(nameof(GalleryCategoryId))]
        [InverseProperty("Galleries")]
        public virtual GalleryCategory GalleryCategory { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("Galleries")]
        public virtual Lang Lang { get; set; }
    }
}