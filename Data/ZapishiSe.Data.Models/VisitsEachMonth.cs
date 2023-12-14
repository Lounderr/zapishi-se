using System;
using System.ComponentModel.DataAnnotations;

namespace ZapishiSe.Data.Models
{
    public class VisitsEachMonth
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Visits { get; set; }

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }
    }
}
