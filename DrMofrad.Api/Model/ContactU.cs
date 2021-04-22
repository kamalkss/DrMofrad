﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class ContactU
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(11)]
        public string Cell { get; set; }
        [StringLength(1000)]
        public string Message { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public bool? IsReaded { get; set; }
    }
}