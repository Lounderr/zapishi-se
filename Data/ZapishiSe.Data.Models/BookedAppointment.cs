using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZapishiSe.Data.Models.Enums;

namespace ZapishiSe.Data.Models
{
    public class BookedAppointment
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        public bool IsAttended { get; set; }

        public DateTime AppointmentStart { get; set; }

        public AppointmentStatus AppointmentStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        [NotMapped]
        public TimeSpan Duration => Service.Duration;

        [NotMapped]
        public DateTime AppointmentEnd => AppointmentStart + Duration;
    }
}
