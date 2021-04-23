#nullable disable

namespace DrMofrad.Api.Model
{
    public class Page
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? LangId { get; set; }
        public string Key { get; set; }

        public virtual Lang Lang { get; set; }
    }
}