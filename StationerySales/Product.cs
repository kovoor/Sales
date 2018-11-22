using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerySales
{
    public class Product
    {
        public string Product_Name { get; set; }
        public string Product_ID { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } //Writing Tools, Notebook & Diary, Office Equipment, Files & Folders, Others
        public int Quantity { get; set; }

        public Product(string nm, string pid, decimal pr, string cat, int qty)
        {
            Product_Name = nm;
            Product_ID = pid;
            Price = pr;
            Category = cat;
            Quantity = qty;
        }

        public Product(string nm, string pid, decimal pr, int qty)
        {
            Product_Name = nm;
            Product_ID = pid;
            Price = pr;
            Quantity = qty;
        }
    }
}
