using System;
using System.ComponentModel.DataAnnotations;
using ZapishiSe.Data.Models.ValidationAttributes;

namespace ZapishiSe.Data.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool HasPriceRange { get; set; } 

        [Range(0.01, 100_000)]
        public decimal BasePrice { get; set; }

        // TODO Validate (Max price range start > Min Price)
        [ServiceMaxPriceRange(nameof(BasePrice), 100_000)]
        public decimal? MaxPrice { get; set; }

        public TimeSpan Duration { get; set; }

        public Business Business { get; set; }
    }
}
