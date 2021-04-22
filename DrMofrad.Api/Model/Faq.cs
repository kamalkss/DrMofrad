using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Index(nameof(LangId), Name = "IX_LangId")]
    public class Faq
    {
        [Key] public int Id { get; set; }

        [Required] [StringLength(2000)] public string Question { get; set; }

        [StringLength(2000)] public string Answer { get; set; }

        public int? ShowCount { get; set; }
        public int? LikeCount { get; set; }

        [Column(TypeName = "datetime")] public DateTime? Date { get; set; }

        public int? LangId { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("Faqs")]
        public virtual Lang Lang { get; set; }
    }
}