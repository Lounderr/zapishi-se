using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ZapishiSe.Data.Models
{
    public class BusinessImage
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string Filetype { get; set; }

        [Required]
        [StringLength(1000)]
        public string Path { get; set; }

        public int Order { get; set; }

        public DateTime CreatedOn { get; set; }

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }
    }
}
