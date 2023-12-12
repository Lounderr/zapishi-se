using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using ZapishiSe.Data.Models.Enums;

namespace ZapishiSe.Data.Models
{
    public class UserReport
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public ReportType ReviewReportCategory { get; set; }

        [Required]
        public virtual ApplicationUser Author { get; set; }

        [Required]
        public virtual ApplicationUser TargetUser { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
