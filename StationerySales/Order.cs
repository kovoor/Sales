using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerySales
{
    public class Order
    {
        public string Reference_Num { get; set; }
        public string Account_Name { get; set; }
        public string Account_ID { get; set; }
        public List<Product> Product { get; set; }
        public string Date { get; set; }

        public Order(string id, string nm, string date, List<Product> product, string refNo)
        {
            Account_ID = id;
            Account_Name = nm;
            Product = product;
            Date = date;
            Reference_Num = refNo;

        }

        public decimal[] getProductTotal()
        {
            decimal[] allProductPrice = new decimal[Product.Count];
            int i = 0;

            foreach(Product p in Product)
            {
                var productPrice = p.Price * (decimal)p.Quantity;
                allProductPrice[i++] = productPrice;
            }

            return allProductPrice;
        }


        public decimal getTotal()
        {
            decimal totalPrice = 0;

            foreach (Product p in Product)
            {
                totalPrice += p.Price * (decimal)p.Quantity;
            }

            return totalPrice;
        }
    }
}
