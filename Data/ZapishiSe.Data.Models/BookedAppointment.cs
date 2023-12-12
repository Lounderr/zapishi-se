using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZapishiSe.Data.Models.Enums;

namespace ZapishiSe.Data.Models
{
    public class BookedAppointment
    {
        public int Id { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; }

        [Required]
        public virtual Business Business { get; set; }

        public virtual Service Service { get; set; }

        [NotMapped]
        public TimeSpan Duration { get; set; }

        public bool IsAttended { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public AppointmentStatus AppointmentStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
