using System;
using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class Article
    {
        public Article()
        {
            Opinions = new HashSet<Opinion>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string ImgUrlOne { get; set; }
        public string ImgUrlTwo { get; set; }
        public int? ShowCount { get; set; }
        public int? LikeCount { get; set; }
        public DateTime? Date { get; set; }
        public int? LangId { get; set; }
        public string SummaryDescription { get; set; }
        public string Tag { get; set; }
        public int? ArticleCategoriesId { get; set; }
        public int? Priority { get; set; }

        public virtual ArticleCategory ArticleCategories { get; set; }
        public virtual Lang Lang { get; set; }
        public virtual ICollection<Opinion> Opinions { get; set; }
    }
}