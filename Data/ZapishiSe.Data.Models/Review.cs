using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ZapishiSe.Data.Models
{
    public enum Pricing
    {
        High,
        Standard,
        Low,
    }

    public class Review
    {
        public int Id { get; set; }

        [Required]
        public string TextContent { get; set; }

        [Required]
        public virtual Business Business { get; set; }

        public Pricing Pricing { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public virtual ApplicationUser Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<ReviewInteraction> ReviewInteractions { get; set; }

        public virtual ICollection<ReviewReport> ReviewReports { get; set; }

        [NotMapped]
        public int LikeCount { get; set; }

        [NotMapped]
        public int DislikeCount { get; set; }

        [NotMapped]
        public int ReviewReportsCount { get; set; }

        [NotMapped]
        public int TrustScore { get; set; }
    }
}
