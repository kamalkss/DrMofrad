using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class File
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string FileUrl { get; set; }
    }
}
