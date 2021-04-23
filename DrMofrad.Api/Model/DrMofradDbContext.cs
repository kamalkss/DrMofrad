using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class DrMofradDbContext : DbContext
    {
        

        public DrMofradDbContext(DbContextOptions<DrMofradDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityCenter> ActivityCenters { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleCategory> ArticleCategories { get; set; }
        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<GalleryCategory> GalleryCategories { get; set; }
        public virtual DbSet<HoursAttend> HoursAttends { get; set; }
        public virtual DbSet<Lang> Langs { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Opinion> Opinions { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<SeoSetting> SeoSettings { get; set; }
        public virtual DbSet<SlideShow> SlideShows { get; set; }
        public virtual DbSet<TelegramChannel> TelegramChannels { get; set; }
        public virtual DbSet<TelegramMessage> TelegramMessages { get; set; }
        public virtual DbSet<TelegramUser> TelegramUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActivityCenter>(entity =>
            {
                entity.HasIndex(e => e.LangId, "IX_LangId");

                entity.Property(e => e.MoreInfo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.ActivityCenters)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.ActivityCenters_dbo.Lang_LangId");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.Cell)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.Clinic)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Text).HasMaxLength(50);

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(1000)
                    .HasColumnName("imgUrl");

                entity.Property(e => e.ImgUrlOne)
                    .HasMaxLength(1000)
                    .HasColumnName("imgUrlOne");

                entity.Property(e => e.ImgUrlTwo)
                    .HasMaxLength(1000)
                    .HasColumnName("imgUrlTwo");

                entity.Property(e => e.SummaryDescription)
                    .IsRequired()
                    .HasMaxLength(97)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tag).HasMaxLength(2000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ArticleCategories)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.ArticleCategoriesId)
                    .HasConstraintName("FK_Articles_ArticleCategories");

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.Articles_dbo.Lang_LangId");
            });

            modelBuilder.Entity<ArticleCategory>(entity =>
            {
                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(1000)
                    .HasColumnName("imgUrl");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.ArticleCategories)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_ArticleCategories_Lang");
            });

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.HasIndex(e => e.LangId, "IX_LangId");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.Clinics)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.Clinics_dbo.Lang_LangId");
            });

            modelBuilder.Entity<ContactU>(entity =>
            {
                entity.Property(e => e.Cell).HasMaxLength(11);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(1000);
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.HasIndex(e => e.LangId, "IX_LangId");

                entity.Property(e => e.Answer).HasMaxLength(2000);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.Faqs)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.Faqs_dbo.Lang_LangId");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(1000)
                    .HasColumnName("imgUrl");

                entity.Property(e => e.ImgUrlOne)
                    .HasMaxLength(1000)
                    .HasColumnName("imgUrlOne");

                entity.Property(e => e.ImgUrlTwo)
                    .HasMaxLength(1000)
                    .HasColumnName("imgUrlTwo");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.GalleryCategory)
                    .WithMany(p => p.Galleries)
                    .HasForeignKey(d => d.GalleryCategoryId)
                    .HasConstraintName("FK_dbo.Galleries_dbo.GalleryCategories_GalleryCategoryId");

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.Galleries)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.Galleries_dbo.Lang_LangId");
            });

            modelBuilder.Entity<GalleryCategory>(entity =>
            {
                entity.HasIndex(e => e.LangId, "IX_LangId");

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(1000)
                    .HasColumnName("imgUrl");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.GalleryCategories)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.GalleryCategories_dbo.Lang_LangId");
            });

            modelBuilder.Entity<HoursAttend>(entity =>
            {
                entity.HasIndex(e => e.LangId, "IX_LangId");

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.HoursAttends)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.HoursAttends_dbo.Lang_LangId");
            });

            modelBuilder.Entity<Lang>(entity =>
            {
                entity.ToTable("Lang");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(1000);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Opinion>(entity =>
            {
                entity.HasIndex(e => e.ArticleId, "IX_ArticleId");

                entity.Property(e => e.Answer).HasMaxLength(2000);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ip).HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(1000);

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.Opinions)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_dbo.Opinions_dbo.Articles_ArticleId");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.HasIndex(e => e.LangId, "IX_LangId");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.Pages)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.Pages_dbo.Lang_LangId");
            });

            modelBuilder.Entity<SeoSetting>(entity =>
            {
                entity.HasIndex(e => e.LangId, "IX_LangId");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.KeywordsPage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TitlePage)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.SeoSettings)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.SeoSettings_dbo.Lang_LangId");
            });

            modelBuilder.Entity<SlideShow>(entity =>
            {
                entity.HasIndex(e => e.LangId, "IX_LangId");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("imageUrl");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.SlideShows)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.SlideShows_dbo.Lang_LangId");
            });

            modelBuilder.Entity<TelegramChannel>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK_dbo.TelegramChannels");

                entity.Property(e => e.Username)
                    .HasMaxLength(200)
                    .HasColumnName("username");

                entity.Property(e => e.Definer).HasColumnName("definer");

                entity.HasOne(d => d.DefinerNavigation)
                    .WithMany(p => p.TelegramChannels)
                    .HasForeignKey(d => d.Definer)
                    .HasConstraintName("FK_TelegramChannels_TelegramUsers");
            });

            modelBuilder.Entity<TelegramMessage>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.FromId })
                    .HasName("PK_dbo.TelegramMessages");

                entity.Property(e => e.MessageId).HasColumnName("message_id");

                entity.Property(e => e.FromId).HasColumnName("from_id");

                entity.Property(e => e.MessageText).HasColumnName("message_text");

                entity.Property(e => e.MessageTime)
                    .HasColumnType("datetime")
                    .HasColumnName("message_time");

                entity.Property(e => e.Response).HasColumnName("response");

                entity.Property(e => e.ResponseTime)
                    .HasColumnType("datetime")
                    .HasColumnName("response_time");

                entity.Property(e => e.ShowInPublic).HasColumnName("show_in_public");

                entity.HasOne(d => d.From)
                    .WithMany(p => p.TelegramMessages)
                    .HasForeignKey(d => d.FromId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TelegramMessages_TelegramUsers");
            });

            modelBuilder.Entity<TelegramUser>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FirstName).HasColumnName("first_name");

                entity.Property(e => e.LanguageCode).HasColumnName("language_code");

                entity.Property(e => e.LastName).HasColumnName("last_name");

                entity.Property(e => e.Username).HasColumnName("username");
            });
        }
    }
}