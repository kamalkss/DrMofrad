using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Table("Lang")]
    public partial class Lang
    {
        public Lang()
        {
            ActivityCenters = new HashSet<ActivityCenter>();
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

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [InverseProperty(nameof(ActivityCenter.Lang))]
        public virtual ICollection<ActivityCenter> ActivityCenters { get; set; }
        [InverseProperty(nameof(Article.Lang))]
        public virtual ICollection<Article> Articles { get; set; }
        [InverseProperty(nameof(Clinic.Lang))]
        public virtual ICollection<Clinic> Clinics { get; set; }
        [InverseProperty(nameof(Faq.Lang))]
        public virtual ICollection<Faq> Faqs { get; set; }
        [InverseProperty(nameof(Gallery.Lang))]
        public virtual ICollection<Gallery> Galleries { get; set; }
        [InverseProperty(nameof(GalleryCategory.Lang))]
        public virtual ICollection<GalleryCategory> GalleryCategories { get; set; }
        [InverseProperty(nameof(HoursAttend.Lang))]
        public virtual ICollection<HoursAttend> HoursAttends { get; set; }
        [InverseProperty(nameof(Page.Lang))]
        public virtual ICollection<Page> Pages { get; set; }
        [InverseProperty(nameof(SeoSetting.Lang))]
        public virtual ICollection<SeoSetting> SeoSettings { get; set; }
        [InverseProperty(nameof(SlideShow.Lang))]
        public virtual ICollection<SlideShow> SlideShows { get; set; }
    }
}
