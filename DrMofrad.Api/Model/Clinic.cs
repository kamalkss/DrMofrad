#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class Clinic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? LangId { get; set; }

        public virtual Lang Lang { get; set; }
    }
}