using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Supplies.Models;

namespace Supplies.DAL
{
    public class SupplyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SupplyContext>
    {
        protected override void Seed(SupplyContext context)
        {
            var Locations = new List<Location>
            {
            new Location{LocationName="Elbow River",CustomerName="Century"},
            new Location{LocationName="Century Casino",CustomerName="Century"},
            new Location{LocationName="Hastings Park",CustomerName="Hastings Park"},
            new Location{LocationName="Breakers",CustomerName="VEA"},
            };

            Locations.ForEach(s => context.Locations.Add(s));
            context.SaveChanges();
            var Products = new List<Product>
            {
            new Product{ProductID=1,Name="Toner-4350"},
            new Product{ProductID=2,Name="Toner-4015"},
            new Product{ProductID=3,Name="Toner-M602"},
            new Product{ProductID=4,Name="Paper"},
            new Product{ProductID=5,Name="Staples"},
            };
            Products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var Orders = new List<Order>
            {
            new Order{LocationID=1,ProductID=2,Quantity=2,Status=Status.Requested,OrderDate=DateTime.Parse("2018-07-18")},
            new Order{LocationID=1,ProductID=4,Quantity=2,Status=Status.Approved,OrderDate=DateTime.Parse("2018-07-15")},
            new Order{LocationID=1,ProductID=5,Quantity=2,Status=Status.Ordered,OrderDate=DateTime.Parse("2018-07-15")},
            new Order{LocationID=2,ProductID=2,Quantity=2,Status=Status.Shipped,OrderDate=DateTime.Parse("2018-07-16")},
            new Order{LocationID=3,ProductID=3,Quantity=2,Status=Status.Completed,OrderDate=DateTime.Parse("2018-07-13")},
            new Order{LocationID=4,ProductID=1,Quantity=2,Status=Status.Requested,OrderDate=DateTime.Parse("2018-07-19")},
            };
            Orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
        }
    }
}