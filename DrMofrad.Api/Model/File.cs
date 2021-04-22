using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class File
    {
        [Key] public int Id { get; set; }

        public string Title { get; set; }
        public string FileUrl { get; set; }
    }
}