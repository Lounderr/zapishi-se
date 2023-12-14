using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ZapishiSe.Data.Models.Enums;

namespace ZapishiSe.Data.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        public Pricing Pricing { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public virtual ICollection<ReviewInteraction> ReviewInteractions { get; set; }

        public virtual ICollection<ReviewReport> ReviewReports { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        [NotMapped]
        public int TotalLikes => ReviewInteractions.Count(x => x.IsLiked == true);

        [NotMapped]
        public int TotalDislikes => ReviewInteractions.Count(x => x.IsLiked == false);

        [NotMapped]
        public int TrustScore { get; set; }

    }
}
