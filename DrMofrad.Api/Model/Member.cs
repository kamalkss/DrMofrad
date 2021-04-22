using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class Member
    {
        [Key] public int Id { get; set; }

        [StringLength(50)] public string FullName { get; set; }

        [StringLength(50)] public string UserName { get; set; }

        [StringLength(1000)] public string Password { get; set; }

        [StringLength(100)] public string Email { get; set; }
    }
}