using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class TelegramUser
    {
        public TelegramUser()
        {
            TelegramChannels = new HashSet<TelegramChannel>();
            TelegramMessages = new HashSet<TelegramMessage>();
        }

        [Key] [Column("id")] public long Id { get; set; }

        [Column("first_name")] public string FirstName { get; set; }

        [Column("last_name")] public string LastName { get; set; }

        [Column("username")] public string Username { get; set; }

        [Column("language_code")] public string LanguageCode { get; set; }

        [InverseProperty(nameof(TelegramChannel.DefinerNavigation))]
        public virtual ICollection<TelegramChannel> TelegramChannels { get; set; }

        [InverseProperty(nameof(TelegramMessage.From))]
        public virtual ICollection<TelegramMessage> TelegramMessages { get; set; }
    }
}