using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZapishiSe.Data.Models
{
    [Owned]
    public class Address
    {
        [Required]
        [StringLength(256)]
        public string Street { get; set; }

        [Required]
        [StringLength(256)]
        public string City { get; set; }

        [NotMapped]
        public string FullAddress => $"{Street}, {City}";
    }
}