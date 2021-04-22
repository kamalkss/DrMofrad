using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
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
                entity.Property(e => e.MoreInfo).HasDefaultValueSql("('')");

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.ActivityCenters)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.ActivityCenters_dbo.Lang_LangId");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.SummaryDescription).HasDefaultValueSql("('')");

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.Articles_dbo.Lang_LangId");
            });

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.Clinics)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.Clinics_dbo.Lang_LangId");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.Faqs)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.Faqs_dbo.Lang_LangId");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
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
                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.GalleryCategories)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.GalleryCategories_dbo.Lang_LangId");
            });

            modelBuilder.Entity<HoursAttend>(entity =>
            {
                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.HoursAttends)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.HoursAttends_dbo.Lang_LangId");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");
            });

            modelBuilder.Entity<Opinion>(entity =>
            {
                entity.HasOne(d => d.Article)
                    .WithMany(p => p.Opinions)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_dbo.Opinions_dbo.Articles_ArticleId");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.Property(e => e.Key).HasDefaultValueSql("('')");

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.Pages)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.Pages_dbo.Lang_LangId");
            });

            modelBuilder.Entity<SeoSetting>(entity =>
            {
                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.SeoSettings)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.SeoSettings_dbo.Lang_LangId");
            });

            modelBuilder.Entity<SlideShow>(entity =>
            {
                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.SlideShows)
                    .HasForeignKey(d => d.LangId)
                    .HasConstraintName("FK_dbo.SlideShows_dbo.Lang_LangId");
            });

            modelBuilder.Entity<TelegramChannel>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK_dbo.TelegramChannels");

                entity.HasOne(d => d.DefinerNavigation)
                    .WithMany(p => p.TelegramChannels)
                    .HasForeignKey(d => d.Definer)
                    .HasConstraintName("FK_TelegramChannels_TelegramUsers");
            });

            modelBuilder.Entity<TelegramMessage>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.FromId })
                    .HasName("PK_dbo.TelegramMessages");

                entity.HasOne(d => d.From)
                    .WithMany(p => p.TelegramMessages)
                    .HasForeignKey(d => d.FromId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TelegramMessages_TelegramUsers");
            });

            modelBuilder.Entity<TelegramUser>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
