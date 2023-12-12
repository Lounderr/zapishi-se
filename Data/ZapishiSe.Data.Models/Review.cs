using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ZapishiSe.Data.Models.Enums;

namespace ZapishiSe.Data.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string TextContent { get; set; }

        [Required]
        public virtual Business Business { get; set; }

        public Pricing Pricing { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public virtual ApplicationUser Author { get; set; }

        public virtual ICollection<ReviewInteraction> ReviewInteractions { get; set; }

        public virtual ICollection<ReviewReport> ReviewReports { get; set; }

        [NotMapped]
        public int TotalLikes { get; set; }

        [NotMapped]
        public int TotalDislikes { get; set; }

        [NotMapped]
        public int TrustScore { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

    }
}
