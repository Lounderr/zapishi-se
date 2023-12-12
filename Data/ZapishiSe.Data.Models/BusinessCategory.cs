using System.Collections.Generic;

namespace ZapishiSe.Data.Models
{
    public class BusinessCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Business> Businesses { get; set; }
    }
}