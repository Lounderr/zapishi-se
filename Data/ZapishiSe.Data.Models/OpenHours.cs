using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapishiSe.Data.Models
{
    public class OpenHours
    {
        public int Id { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public TimeOnly OpeningTime { get; set; }

        public TimeOnly ClosingTime { get; set; }

        public virtual ICollection<Break> Breaks { get; set; }

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }
    }
}
