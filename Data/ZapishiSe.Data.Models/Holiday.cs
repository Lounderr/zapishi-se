using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapishiSe.Data.Models
{
    public class Holiday
    {
        public int Id { get; set; }

        public DateOnly HolidayStart { get; set; }

        public DateOnly HolidayEnd { get; set; }

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }
    }
}
