#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class ActivityCenter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? LangId { get; set; }
        public string MoreInfo { get; set; }

        public virtual Lang Lang { get; set; }
    }
}