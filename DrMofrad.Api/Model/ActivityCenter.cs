using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Index(nameof(LangId), Name = "IX_LangId")]
    public partial class ActivityCenter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public int? LangId { get; set; }
        [Required]
        [StringLength(200)]
        public string MoreInfo { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("ActivityCenters")]
        public virtual Lang Lang { get; set; }
    }
}
