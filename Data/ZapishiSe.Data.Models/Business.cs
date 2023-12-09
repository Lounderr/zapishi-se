using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ZapishiSe.Data.Models
{
    public class Business
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(256)]
        public string Address { get; set; }

        [Required]
        [StringLength(16)]
        public string Phone { get; set; }

        [Required]
        public virtual ApplicationUser Owner { get; set; }

        public virtual ICollection<BusinessPromotion> BusinessPromotions { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<VisitsEachMonth> VisitsEachMonth { get; set; }

        public virtual ICollection<BusinessImage> BusinessImages { get; set; }

        public virtual ICollection<BusinessReport> BusinessReports { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<ApplicationUser> Favoriters { get; set; }

        public virtual ICollection<BookedAppointment> BookedAppintments { get; set; }

        [Required]
        public virtual ICollection<Service> Services { get; set; }

        [Required]
        public virtual ICollection<Workday> Workdays { get; set; }

        public virtual ICollection<Holiday> Holidays { get; set; }

        [NotMapped]
        public int VisitsThisMonth { get => this.VisitsEachMonth.Where(x => x.Year == DateTime.Now.Year && x.Month == DateTime.Now.Month).Single().Visits; }

        [NotMapped]
        public bool IsPromotionActive => this.BusinessPromotions?.Any(x => x.EndDateTime > DateTime.Now && x.StartDateTime <= DateTime.Now) ?? false; // may throw null error

        [NotMapped]
        public int TrustScore { get; set; }

        [NotMapped]
        public int BusinessRatingsAvg { get; set; }

        [NotMapped]
        public int ReviewsCount { get; set; }

        [NotMapped]
        public int FavoritersCount { get; set; }
    }
}
