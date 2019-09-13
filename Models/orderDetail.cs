using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using rc907613_mis4200.Models;

namespace rc907613_mis4200.Models
{
    public class orderDetail
    {
        public int orderDetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int orderID { get; set; }
        public virtual customerOrder Order { get; set; }
        // the next two properties link the orderDetail to the Product
        public int productID { get; set; }
        public virtual product { get; set; }
        
}

}
