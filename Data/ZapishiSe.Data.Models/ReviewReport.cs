using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using ZapishiSe.Data.Models.Enums;

namespace ZapishiSe.Data.Models
{
    public class ReviewReport
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        public ReportType ReportCategory { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public int ReviewId { get; set; }

        public virtual Review Review { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
