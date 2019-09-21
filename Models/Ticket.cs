using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rc907613_mis4200.Models
{
    public class Ticket
    {

        public int ticketID { get; set; }
        public string eventName { get; set; }
        public string eventLocation { get; set; }
        public DateTime eventDate { get; set; }
        public string eventDuration { get; set; }
        public string eventCost { get; set; }

        public ICollection<Event> Event { get; set; }

    }
}