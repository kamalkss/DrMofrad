using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    [Index(nameof(LangId), Name = "IX_LangId")]
    public partial class HoursAttend
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string Day { get; set; }
        [Required]
        [StringLength(1000)]
        public string Time { get; set; }
        public int? LangId { get; set; }

        [ForeignKey(nameof(LangId))]
        [InverseProperty("HoursAttends")]
        public virtual Lang Lang { get; set; }
    }
}
