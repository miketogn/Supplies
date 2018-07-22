using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supplies.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string LocationName { get; set; }
        public string CustomerName { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }
    }
}