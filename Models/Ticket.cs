using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rc907613_mis4200.Models
{
    public class Ticket
    {

        public int ticketID { get; set; }

        [Display(Name = "Event Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "Event Name Required")]
        public string eventName { get; set; }

        [Display(Name = "Location")]
        [StringLength(100)]
        [Required(ErrorMessage = "Location Required")]
        public string eventLocation { get; set; }

        [Display(Name = "Date")]
        [RegularExpression(@"^(((0?[1-9]|1[012])/(0?[1-9]|1\d|2[0-8])|(0?[13456789]|1[012])/(29|30)|(0?[13578]|1[02])/31)/(19|[2-9]\d)\d{2}|0?2/29/((19|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(([2468][048]|[3579][26])00)))$", ErrorMessage = "Must be in MM/dd/yyyy format")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime eventDate { get; set; }

        [Display(Name ="Duration")]
        [Required]
        public string eventDuration { get; set; }

        [Display(Name = "Cost")]
        [Required]
        public string eventCost { get; set; }

        public ICollection<Event> Event { get; set; }

    }
}