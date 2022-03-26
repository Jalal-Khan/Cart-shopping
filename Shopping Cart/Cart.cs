using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Cart
    {
        List<Product> ProductList = new List<Product>();
        public void AddProduct()
        {
            Console.WriteLine("**************ADD PRODUCT**************");
            Console.Write("Name : ");
            var name = Console.ReadLine();
            
            Console.Write("price : ");
            
            string _price = Console.ReadLine();
            int price = Convert.ToInt32(_price);

            Console.Write("Discount :");
            string _discount = Console.ReadLine();
            int discount = Convert.ToInt32(_discount);
            
            Product addProduct = new Product(name, price, discount);

            ProductList.Add(addProduct);
        }

        public void DeleteProduct(/*List<Product> ProductsList*/)
        {
            Console.WriteLine("***************DELETION*************");
            Console.WriteLine("ENTER NAME OF PRODUCT");
            string key = Console.ReadLine();
            for(int i=0;i<ProductList.Count;i++)
            {
                if(ProductList[i].Name==key)
                {
                    ProductList.Remove(ProductList[i]);
                    Console.WriteLine("Deleted");
                }
            }
        }
        public void menu()
        {
            Console.WriteLine("***********TO DO LIST APPLICATION*******************");
            Console.WriteLine("PRESS 1 FOR \"ADD PRODUCT\"");
            Console.WriteLine("PRESS 2 FOR \"DELETE PRODUCT\"");
            Console.WriteLine("PRESS 3 FOR \"PRODUCT LIST\"");
            Console.WriteLine("PRESS 4 FOR \"CEARING CONSOLE\"");
            Console.WriteLine("PRESS 0 FOR \"EXIT\"");


        }
        public string DisplayProducts()
        {
            var report = new StringBuilder();
            report.AppendLine("ID\tNAME\tprice\tdiscount");
            foreach(Product item in ProductList)
            {
                report.AppendLine($"{item.ID}\t{item.Name}\t{item.Price}\t{item.Discount}");
            }
            return report.ToString();
        }

        public int TotalPrice()
        {
            int report = 0; 
            
            foreach (Product item in ProductList)
            {
                report = report + item.Price;
                //report.AppendLine($"{item.ID}\t{item.Name}\t{item.Price}\t{item.Discount}");
            }
            return report;
        }

        public int TotalDiscount()
        {
            int report = 0;
            
            foreach (Product item in ProductList)
            {
                report = report + item.Discount;
                
            }
            return report;
        }
        public int TotalValue()
        {
            int report=TotalPrice() - TotalDiscount();
            
           
            return report;
        }





    }
}
