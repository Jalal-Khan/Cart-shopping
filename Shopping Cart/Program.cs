using System;

namespace Shopping_Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.menu();
           
            string key = string.Empty;

            do
            {

                //key = string.Empty;
                Console.Write("\n Please Press any key:");
                key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        //add(list);
                        cart.AddProduct();

                        break;

                    case "2":
                        cart.DeleteProduct();
                        break;

                    case "3":
                        Console.WriteLine(cart.DisplayProducts());
                        Console.Write("Total Price : ");
                        Console.Write(cart.TotalPrice());
                        Console.Write("\nTotal Discount : ");
                        Console.Write(cart.TotalDiscount());
                        Console.Write("\nTotal Value : ");
                        Console.Write(cart.TotalValue());
                        break;

                    case "4":
                        Console.Clear();
                        cart.menu();
                        
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("PLEASE PRESS A VALID KEY");
                        break;

                }
            }
            while (key != "0");
            Console.WriteLine("Press any key to close Application");
            Console.ReadKey();

        }
       
    }
}

