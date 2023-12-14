using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapishiSe.Data.Models
{
    public class Break
    {
        public int Id { get; set; }

        public TimeOnly BreakStart { get; set; }

        public TimeOnly BreakEnd { get; set; }

        public int OpenHoursId { get; set; }

        public virtual OpenHours OpenHours { get; set; }
    }
}
