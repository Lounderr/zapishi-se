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

        [ServiceMaxPriceRange(nameof(BasePrice), 100_000)]
        public decimal? MaxPrice { get; set; }

        public TimeSpan Duration { get; set; }

        public int BusinessId { get; set; }

        public Business Business { get; set; }

        //public int BookedAppointmentId { get; set; }

        //public BookedAppointment BookedAppointment { get; set; }
    }
}
