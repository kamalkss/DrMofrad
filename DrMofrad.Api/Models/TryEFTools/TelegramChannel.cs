﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Models.TryEFTools
{
    public partial class TelegramChannel
    {
        public string Username { get; set; }
        public long? Definer { get; set; }

        public virtual TelegramUser DefinerNavigation { get; set; }
    }
}