using System;
using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class SeoSetting
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string TitlePage { get; set; }
        public string KeywordsPage { get; set; }
        public string Description { get; set; }
        public int? LangId { get; set; }

        public virtual Lang Lang { get; set; }
    }
}
