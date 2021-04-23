#nullable disable

namespace DrMofrad.Api.Model
{
    public class HoursAttend
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public int? LangId { get; set; }

        public virtual Lang Lang { get; set; }
    }
}