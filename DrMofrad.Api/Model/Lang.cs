using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class Lang
    {
        public Lang()
        {
            ActivityCenters = new HashSet<ActivityCenter>();
            ArticleCategories = new HashSet<ArticleCategory>();
            Articles = new HashSet<Article>();
            Clinics = new HashSet<Clinic>();
            Faqs = new HashSet<Faq>();
            Galleries = new HashSet<Gallery>();
            GalleryCategories = new HashSet<GalleryCategory>();
            HoursAttends = new HashSet<HoursAttend>();
            Pages = new HashSet<Page>();
            SeoSettings = new HashSet<SeoSetting>();
            SlideShows = new HashSet<SlideShow>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<ActivityCenter> ActivityCenters { get; set; }
        public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Clinic> Clinics { get; set; }
        public virtual ICollection<Faq> Faqs { get; set; }
        public virtual ICollection<Gallery> Galleries { get; set; }
        public virtual ICollection<GalleryCategory> GalleryCategories { get; set; }
        public virtual ICollection<HoursAttend> HoursAttends { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
        public virtual ICollection<SeoSetting> SeoSettings { get; set; }
        public virtual ICollection<SlideShow> SlideShows { get; set; }
    }
}