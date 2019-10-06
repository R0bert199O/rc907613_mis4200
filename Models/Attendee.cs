using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rc907613_mis4200.Models
{
    public class Attendee
    {
        public int attendeeID { get; set; }

        [Display (Name="First Name")]
        [StringLength(30)]
        [Required (ErrorMessage = "First Name Required")]        
        public string firstName { get; set; }

        [Display (Name ="Last Name")]
        [StringLength(30)]
        [Required(ErrorMessage = "Last Name Required")]        
        public string lastName { get; set; }

        [Display (Name ="Name")]
        public string fullName { get { return lastName + ", " + firstName; } }

        [Display (Name = "Street Address")]
        [StringLength(100)]
        [Required (ErrorMessage = "Street Address Required")]        
        public string address { get; set; }

        [Display (Name ="City")]
        [StringLength(30)]
        [Required (ErrorMessage = "City Required")]        
        public string city { get; set; }

        [Display (Name ="State")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "State Must Be 2 Characters")]
        [Required (ErrorMessage = "State Required")]        
        public string state { get; set; }

        [Display (Name ="Zip Code")]
        [StringLength(5)]
        [Required (ErrorMessage = "Zip Code Required")]        
        public string zip { get; set;  }

        [Display (Name ="Email")]
        [Required (ErrorMessage = "Email Required")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display (Name ="Phone Number")]
        [Required (ErrorMessage = "Phone Number Required")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        public ICollection<Event> Event { get; set; }

    }
}