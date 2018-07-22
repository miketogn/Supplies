﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supplies.Models
{
    public enum Status
    {
        Requested, Approved, Ordered, Shipped, Completed
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public int LocationID { get; set; }
        public Status? Status { get; set; }

        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
    }
}