using System.Linq;
using DrMofrad.Api.Model;
using HotChocolate;
using HotChocolate.Data;

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
    }
}