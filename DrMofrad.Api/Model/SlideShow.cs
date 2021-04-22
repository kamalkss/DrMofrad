using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Index(nameof(LangId), Name = "IX_LangId")]
    public class SlideShow
    {
        [Key] public int Id { get; set; }

        [Required] [StringLength(200)] public string Title { get; set; }

        [Required] [StringLength(2000)] public string Description { get; set; }

        [Required]
        [Column("imageUrl")]
        [StringLength(1000)]
        public string ImageUrl { get; set; }

        public int Orders { get; set; }
        public int? LangId { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("SlideShows")]
        public virtual Lang Lang { get; set; }
    }
}