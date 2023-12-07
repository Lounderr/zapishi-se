using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZapishiSe.Data.Models
{
    public class Conversation
    {
        public int Id { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<ApplicationUser> Participants { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
