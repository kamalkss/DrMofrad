﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Models.TryEFTools
{
    public partial class Opinion
    {
        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Ip { get; set; }
        public DateTime? Date { get; set; }
        public bool? Accept { get; set; }
        public bool? IsReaded { get; set; }
        public string Answer { get; set; }

        public virtual Article Article { get; set; }
    }
}