using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppRefactor
{
    public class Product
    {
        private int ProductId { get; set; }
        private string ProductName { get; set; }
        private double ProductPrice { get; set; }
        private double DiscountOnProduct { get; set; }
        public Product(int productId, string productName, double productPrice, double discountOnProduct)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.DiscountOnProduct = discountOnProduct;
        }

        public double CalculateDiscountedProductPrice()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine($"MRP on the product {ProductName} is {ProductPrice}");
            Console.WriteLine(" ");
            Console.WriteLine($"Discount on the product {ProductName} is {DiscountOnProduct}%");
            Console.WriteLine(" ");
            return ProductPrice - (ProductPrice * (DiscountOnProduct / 100.00));
        }

        public void DisplayProductDetails()
        {
            double storeCalculatedFinalPriceResult = CalculateDiscountedProductPrice();
            Console.WriteLine("| {0, -19} | {1, -19} | {2, -19} | {3, -19} |",
                "PRODUCT ID", "PRODUCT NAME", "PRODUCTPRICE", "DISCOUNTED PRICE");
            Console.WriteLine("| {0, -19} | {1, -19} | {2, -19} | {3, -19} |",
                ProductId, ProductName, ProductPrice, storeCalculatedFinalPriceResult);
        }
    }
}
