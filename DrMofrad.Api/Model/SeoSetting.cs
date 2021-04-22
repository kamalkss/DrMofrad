using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Index(nameof(LangId), Name = "IX_LangId")]
    public partial class SeoSetting
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string PageName { get; set; }
        [Required]
        [StringLength(200)]
        public string TitlePage { get; set; }
        [Required]
        [StringLength(4000)]
        public string KeywordsPage { get; set; }
        [Required]
        [StringLength(4000)]
        public string Description { get; set; }
        public int? LangId { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("SeoSettings")]
        public virtual Lang Lang { get; set; }
    }
}
