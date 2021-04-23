using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class ArticleCategory
    {
        public ArticleCategory()
        {
            Articles = new HashSet<Article>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public int? LangId { get; set; }

        public virtual Lang Lang { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}