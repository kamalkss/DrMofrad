using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class Appointment
    {
        [Key] public int Id { get; set; }

        [Required] [StringLength(50)] public string FullName { get; set; }

        [Required] [StringLength(11)] public string Cell { get; set; }

        [Required] [StringLength(50)] public string Clinic { get; set; }

        [Column(TypeName = "datetime")] public DateTime? Date { get; set; }

        [Required] [StringLength(8)] public string Time { get; set; }

        [StringLength(50)] public string Text { get; set; }

        public bool? IsReaded { get; set; }
    }
}