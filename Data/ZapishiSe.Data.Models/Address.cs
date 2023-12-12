using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZapishiSe.Data.Models
{
    public class Address
    {
        public int Id { get; set; }

        [NotMapped]
        public string FullAddress => $"{Street}, {City}";

        [StringLength(256)]
        public string Street { get; set; }

        [StringLength(256)]
        public string City { get; set; }
    }
}