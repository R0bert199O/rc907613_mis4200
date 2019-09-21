using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rc907613_mis4200.Models
{
    public class Event
    {

        public int eventID { get; set; }

        public int attendeeID { get; set; }
        public virtual Attendee Attendee { get; set; }

        public int ticketID { get; set; }
        public virtual Ticket Ticket { get; set; }

    }
}