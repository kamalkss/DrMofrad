using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class Article
    {
        public Article()
        {
            Opinions = new HashSet<Opinion>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Column("imgUrl")]
        [StringLength(1000)]
        public string ImgUrl { get; set; }
        [Column("imgUrlOne")]
        [StringLength(1000)]
        public string ImgUrlOne { get; set; }
        [Column("imgUrlTwo")]
        [StringLength(1000)]
        public string ImgUrlTwo { get; set; }
        public int? ShowCount { get; set; }
        public int? LikeCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public int? LangId { get; set; }
        [Required]
        [StringLength(97)]
        public string SummaryDescription { get; set; }
        [StringLength(2000)]
        public string Tag { get; set; }
        public int? ArticleCategoriesId { get; set; }
        public int? Priority { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("Articles")]
        public virtual Lang Lang { get; set; }
        [InverseProperty(nameof(Opinion.Article))]
        public virtual ICollection<Opinion> Opinions { get; set; }
    }
}
