using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crow_MIS4200.Models
{
    public class customer
    {
        public int customerId { get; set; }
        //primary key by default, will pick ID first, and then after that it will look for a classId (customerId)
        public int firstName { get; set; }
        public int lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        //customer can have many orders

        public ICollection<order> orders { get; set; }

        //ICollection I: Interface
        //if you see <> it wants a data type. In this case order from our order class
        //this will show all orders placed by this customer
    }
}