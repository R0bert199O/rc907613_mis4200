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
        [DataType(DataType.Date, ErrorMessage = "Date must be in mm/dd/yyyy format")]
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