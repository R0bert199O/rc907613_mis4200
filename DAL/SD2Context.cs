using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using rc907613_mis4200.Models;
using System.Data.Entity;

namespace rc907613_mis4200.DAL
{
    public class SD2Context : DbContext
    {
        public SD2Context(): base("name=DefaultConnection")
        {

        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Event> Events { get; set; }




    }
}