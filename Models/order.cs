using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crow_MIS4200.Models
{
    public class order
    {
        public int orderId { get; set; }
        //primary key by default, will pick ID first, and then after that it will look for a classId (customerId)
        public int customerId { get; set; }
        public virtual customer customer { get; set; }
        //virtual causes it to load as needed, if you just want it to load from the beginning, take out virtual
        //datatype can be any object. Embedding the foreign object "customer" information in the order table
        public DateTime orderDate { get; set; }
     }
}