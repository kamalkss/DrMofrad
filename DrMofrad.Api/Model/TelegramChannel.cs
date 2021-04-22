using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class TelegramChannel
    {
        [Key]
        [Column("username")]
        [StringLength(200)]
        public string Username { get; set; }
        [Column("definer")]
        public long? Definer { get; set; }

        [ForeignKey(nameof(Definer))]
        [InverseProperty(nameof(TelegramUser.TelegramChannels))]
        public virtual TelegramUser DefinerNavigation { get; set; }
    }
}
