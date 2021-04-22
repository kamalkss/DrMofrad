using System;
using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using DrMofrad.Api.Model;
using HotChocolate.Data;
using System.Threading.Tasks;

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

        public IQueryable<Model.Member> GetMembers([ScopedService] DrMofradDbContext member) => member.Members;

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

        public IQueryable<Model.GalleryCategory> GetGalleryCategories([ScopedService] DrMofradDbContext member) => member.GalleryCategories;

        public Model.GalleryCategory FirsGalleryCategory([ScopedService] DrMofradDbContext drMofradDbContext)
        {
            return drMofradDbContext.GalleryCategories.FirstOrDefault();
        }
        #endregion
    }
}
