using System;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class Faq
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int? ShowCount { get; set; }
        public int? LikeCount { get; set; }
        public DateTime? Date { get; set; }
        public int? LangId { get; set; }

        public virtual Lang Lang { get; set; }
    }
}