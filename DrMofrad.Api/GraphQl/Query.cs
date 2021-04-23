using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Data;
using System.Linq;

namespace DrMofrad.Api.GraphQl
{
    public class Query
    {
        #region Member

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext member)
        {
            return member.Members;
        }

        public Model.Member FirstMember([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Members.FirstOrDefault();
        }

        #endregion Member

        #region GalleryCategories

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.GalleryCategory> GetGalleryCategories([ScopedService] DrMofradDbContext member)
        {
            return member.GalleryCategories;
        }

        public Model.GalleryCategory FirsGalleryCategory([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.GalleryCategories.FirstOrDefault();
        }

        #endregion GalleryCategories

        #region Gallery

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.Gallery> GetGalleries([ScopedService] DrMofradDbContext member)
        {
            return member.Galleries;
        }

        public Model.Gallery FirstGallery([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Galleries.FirstOrDefault();
        }

        #endregion Gallery

        #region activityCenter

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.ActivityCenter> GetActivityCenters([ScopedService] DrMofradDbContext member)
        {
            return member.ActivityCenters;
        }

        public Model.ActivityCenter FirstActivityCenter([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.ActivityCenters.FirstOrDefault();
        }

        #endregion activityCenter

        #region Appointment

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.Appointment> GetAppointments([ScopedService] DrMofradDbContext member)
        {
            return member.Appointments;
        }

        public Model.Appointment FirstAppointment([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Appointments.FirstOrDefault();
        }

        #endregion Appointment

        #region Article

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.Article> GetArticles([ScopedService] DrMofradDbContext member)
        {
            return member.Articles;
        }

        public Model.Article FirstArticle([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Articles.FirstOrDefault();
        }

        #endregion Article

        #region ArticleCategories

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.ArticleCategory> GetArticleCategories([ScopedService] DrMofradDbContext member)
        {
            return member.ArticleCategories;
        }

        public Model.ArticleCategory FirsArticleCategory([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.ArticleCategories.FirstOrDefault();
        }

        #endregion ArticleCategories

        #region Clinic

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.Clinic> GetClinics([ScopedService] DrMofradDbContext member)
        {
            return member.Clinics;
        }

        public Model.Clinic FirstClinic([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Clinics.FirstOrDefault();
        }

        #endregion Clinic

        #region ContactUs

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.ContactU> GetContactUs([ScopedService] DrMofradDbContext member)
        {
            return member.ContactUs;
        }

        public Model.ContactU FirstContactUs([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.ContactUs.FirstOrDefault();
        }

        #endregion ContactUs

        #region faq

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.Faq> GetFaqs([ScopedService] DrMofradDbContext member)
        {
            return member.Faqs;
        }

        public Model.Faq FirstFaq([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Faqs.FirstOrDefault();
        }

        #endregion faq

        #region File

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.File> GetFiles([ScopedService] DrMofradDbContext member)
        {
            return member.Files;
        }

        public Model.File FirstFile([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Files.FirstOrDefault();
        }

        #endregion File

        #region HoursAttend

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.HoursAttend> GetHoursAttends([ScopedService] DrMofradDbContext member)
        {
            return member.HoursAttends;
        }

        public Model.HoursAttend FirstHoursAttend([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.HoursAttends.FirstOrDefault();
        }

        #endregion HoursAttend

        #region Opinion

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.Opinion> GetOpinions([ScopedService] DrMofradDbContext member)
        {
            return member.Opinions;
        }

        public Model.Opinion FirstOpinion([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Opinions.FirstOrDefault();
        }

        #endregion Opinion

        #region Page

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.Page> GetPages([ScopedService] DrMofradDbContext member)
        {
            return member.Pages;
        }

        public Model.Page FirstPage([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Pages.FirstOrDefault();
        }

        #endregion Page

        #region SeoSetting

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.SeoSetting> GetSeoSettings([ScopedService] DrMofradDbContext member)
        {
            return member.SeoSettings;
        }

        public Model.SeoSetting FirstSeoSetting([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.SeoSettings.FirstOrDefault();
        }

        #endregion SeoSetting

        #region SlideShow

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.SlideShow> GetSlideShows([ScopedService] DrMofradDbContext member)
        {
            return member.SlideShows;
        }

        public Model.SlideShow FirstSlideShow([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.SlideShows.FirstOrDefault();
        }

        #endregion SlideShow

        #region Lang

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.Lang> GetLangs([ScopedService] DrMofradDbContext member)
        {
            return member.Langs;
        }

        public Model.Lang FirstLang([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.Langs.FirstOrDefault();
        }

        #endregion Lang

        #region TelegramMessage

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.TelegramMessage> GeTelegramMessages([ScopedService] DrMofradDbContext member)
        {
            return member.TelegramMessages;
        }

        public Model.TelegramMessage FirsTelegramMessage([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.TelegramMessages.FirstOrDefault();
        }

        #endregion TelegramMessage

        #region TelegramUser

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.TelegramUser> GetTelegramUsers([ScopedService] DrMofradDbContext member)
        {
            return member.TelegramUsers;
        }

        public Model.TelegramUser FirsTelegramUser([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.TelegramUsers.FirstOrDefault();
        }

        #endregion TelegramUser

        #region Lang

        [UseDbContext(typeof(DrMofradDbContext))]
        [UseSorting]
        [UseFiltering]
        //public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext drMofradDbContext)
        //{
        //    return drMofradDbContext.Members;
        //}
        public IQueryable<Model.TelegramChannel> GetTelegramChannels([ScopedService] DrMofradDbContext member)
        {
            return member.TelegramChannels;
        }

        public Model.TelegramChannel FirstTelegramChannel([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.TelegramChannels.FirstOrDefault();
        }

        #endregion Lang
    }
}