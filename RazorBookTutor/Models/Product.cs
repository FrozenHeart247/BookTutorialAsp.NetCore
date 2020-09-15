using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBookTutor.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product() { }
        public Product(int prodId, string name, string descr, decimal price, string category)
        {
            ProductID = prodId;
            Name = name;
            Description = descr;
            Price = price;
            Category = category;

        }
    }
}
