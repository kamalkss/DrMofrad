﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Models.TryEFTools
{
    public partial class TelegramMessage
    {
        public int MessageId { get; set; }
        public long FromId { get; set; }
        public string MessageText { get; set; }
        public string Response { get; set; }
        public bool? ShowInPublic { get; set; }
        public DateTime? MessageTime { get; set; }
        public DateTime? ResponseTime { get; set; }

        public virtual TelegramUser From { get; set; }
    }
}