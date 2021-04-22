using System;

#nullable disable

namespace DrMofrad.Api.Model
{
    public partial class ContactU
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsReaded { get; set; }
    }
}