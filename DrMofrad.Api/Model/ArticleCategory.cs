using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class ArticleCategory
    {
        [Key] public int Id { get; set; }

        [StringLength(50)] public string Title { get; set; }

        [Column("imgUrl")]
        [StringLength(1000)]
        public string ImgUrl { get; set; }

        public int? LangId { get; set; }
    }
}