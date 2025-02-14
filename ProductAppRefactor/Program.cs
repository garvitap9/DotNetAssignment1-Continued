using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppRefactor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(121, "Almonds (1 Kg)", 1299.00, 10);
            Product product2 = new Product(124, "Walnuts (1 Kg)", 1599.00, 15);
            Console.WriteLine(" ");
            Console.WriteLine("Welcome To Apna Bazaar");
            Console.WriteLine(" ");
            product1.DisplayProductDetails();
            product2.DisplayProductDetails();
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        }
    }
}
