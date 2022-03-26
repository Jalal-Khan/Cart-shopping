using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Product
    {
        public int ID { get;  }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        private static int idSeed = 1;

        public Product(string name, int price, int discount)
        {
            this.ID = idSeed;
            idSeed = idSeed + 1;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
        }
    }

    
}
