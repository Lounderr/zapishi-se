using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Range(0.01, 100_000)]
        public decimal? MaxPrice { get; set; }

        public TimeOnly Duration { get; set; }
    }
}
