using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class Member
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(1000)]
        public string Password { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
    }
}
