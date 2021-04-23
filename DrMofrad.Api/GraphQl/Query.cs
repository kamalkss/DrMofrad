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

        #endregion 

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

        #endregion 

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

        #endregion 

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

        #endregion 

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

        #endregion 

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

        #endregion

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

        #endregion 

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

        #endregion
    }
}