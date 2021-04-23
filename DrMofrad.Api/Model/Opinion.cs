using System;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class Opinion
    {
        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Ip { get; set; }
        public DateTime? Date { get; set; }
        public bool? Accept { get; set; }
        public bool? IsReaded { get; set; }
        public string Answer { get; set; }

        public virtual Article Article { get; set; }
    }
}