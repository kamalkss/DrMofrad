using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Index(nameof(LangId), Name = "IX_LangId")]
    public partial class Page
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(4000)]
        public string Description { get; set; }
        public int? LangId { get; set; }
        [Required]
        [StringLength(100)]
        public string Key { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("Pages")]
        public virtual Lang Lang { get; set; }
    }
}
