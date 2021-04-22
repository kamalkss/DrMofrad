using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Index(nameof(ArticleId), Name = "IX_ArticleId")]
    public class Opinion
    {
        [Key] public int Id { get; set; }

        public int? ArticleId { get; set; }

        [Required] [StringLength(50)] public string FullName { get; set; }

        [StringLength(100)] public string Email { get; set; }

        [StringLength(1000)] public string Message { get; set; }

        [StringLength(50)] public string Ip { get; set; }

        [Column(TypeName = "datetime")] public DateTime? Date { get; set; }

        public bool? Accept { get; set; }
        public bool? IsReaded { get; set; }

        [StringLength(2000)] public string Answer { get; set; }

        [ForeignKey(nameof(ArticleId))]
        [InverseProperty("Opinions")]
        public virtual Article Article { get; set; }
    }
}