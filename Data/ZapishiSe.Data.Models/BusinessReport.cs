using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using ZapishiSe.Data.Models.Enums;

namespace ZapishiSe.Data.Models
{
    public class BusinessReport
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string TextContent { get; set; }

        public ReportType BusinessReportCategory { get; set; }

        [Required]
        public virtual Business Business { get; set; }

        [Required]
        public virtual ApplicationUser Author { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
