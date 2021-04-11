using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CENG396WWTTMS.Models.DB
{
    public partial class Trouble
    {
        public int TtNumber { get; set; }
        [Required]
        [Display(Name = "Abonnement Number")]
        public int AbonNum { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "Trouble Description")]
        [StringLength(50, ErrorMessage = "This field's length can't be more than 50.")] 
        public string TroubleDesc { get; set; }
        
        public int? CrewAssignedId { get; set; }
        
        public string TicketState { get; set; }

        public virtual Client AbonNumNavigation { get; set; }
        
        public virtual Crew CrewAssigned { get; set; }
    }
}
