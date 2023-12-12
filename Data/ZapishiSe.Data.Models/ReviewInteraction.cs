using System;
using System.ComponentModel.DataAnnotations;

namespace ZapishiSe.Data.Models
{
    public class ReviewInteraction
    {
        public int Id { get; set; }

        public bool? IsLiked { get; set; }

        [Required]
        public virtual ApplicationUser Author { get; set; }

        [Required]
        public virtual Review Review { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
