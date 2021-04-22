using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class TelegramMessage
    {
        [Key] [Column("message_id")] public int MessageId { get; set; }

        [Key] [Column("from_id")] public long FromId { get; set; }

        [Column("message_text")] public string MessageText { get; set; }

        [Column("response")] public string Response { get; set; }

        [Column("show_in_public")] public bool? ShowInPublic { get; set; }

        [Column("message_time", TypeName = "datetime")]
        public DateTime? MessageTime { get; set; }

        [Column("response_time", TypeName = "datetime")]
        public DateTime? ResponseTime { get; set; }

        [ForeignKey(nameof(FromId))]
        [InverseProperty(nameof(TelegramUser.TelegramMessages))]
        public virtual TelegramUser From { get; set; }
    }
}