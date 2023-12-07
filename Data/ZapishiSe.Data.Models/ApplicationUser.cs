// ReSharper disable VirtualMemberCallInConstructor
namespace ZapishiSe.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;
    using ZapishiSe.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string ProfilePicturePath { get; set; }

        public bool IsBusinessAccount { get; set; }

        public DateTime LastActive { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<Business> Businesses { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<ReviewInteraction> ReviewInteractions { get; set; }

        public virtual ICollection<Conversation> Conversations { get; set; }

        public virtual ICollection<BookedAppointment> BookedAppointments { get; set; }

        public virtual ICollection<Business> FavoriteBusinesses { get; set; }

        [NotMapped]
        public int ReliabilityScore { get; set; }

        [NotMapped]
        public int TrustScore { get; set; }
    }
}
