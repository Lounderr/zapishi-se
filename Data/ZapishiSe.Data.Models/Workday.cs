using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapishiSe.Data.Models
{
    public class Workday
    {
        public int Id { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public TimeOnly WorkdayStart { get; set; }

        public TimeOnly WorkdayEnd { get; set; }

        public virtual ICollection<Break> Breaks { get; set; }

        public virtual Business Business { get; set; }
    }
}
