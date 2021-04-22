using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Index(nameof(LangId), Name = "IX_LangId")]
    public class Clinic
    {
        [Key] public int Id { get; set; }

        [Required] [StringLength(50)] public string Title { get; set; }

        public int? LangId { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("Clinics")]
        public virtual Lang Lang { get; set; }
    }
}