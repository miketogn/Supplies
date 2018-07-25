using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Supplies.Models
{
    public class Location
    {
        public int ID { get; set; }
        [Display(Name = "Location")]
        public string LocationName { get; set; }
        [Display(Name = "Customer")]
        public string CustomerName { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }
    }
}