using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="bilgesayar"},
                new Category{CategoryId=1,CategoryName="Telefon"},
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="acer laptop",QuantityPerUnit="8gb ram",UnitPrice=6000,UnitsInStock=5},
                new Product{ProductId=2,CategoryId=1,ProductName="asuslaptop",QuantityPerUnit="16gb ram",UnitPrice=8000,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="hp laptop",QuantityPerUnit="32gb ram",UnitPrice=10000,UnitsInStock=21},
                new Product{ProductId=4,CategoryId=2,ProductName="samsung telefon",QuantityPerUnit="4gb ram",UnitPrice=5000,UnitsInStock=15},
                new Product{ProductId=5,CategoryId=2,ProductName="apple telefon",QuantityPerUnit="4gb ram",UnitPrice=8000,UnitsInStock=0},
            };
            //foreach (var product in products)
            //{//bu foreachle her fiyattan ürün gösterdik eğer mizsadece 8k nın altında bir ürün göstermek istiyorsak LİNQ kullanılırz
            // //eğer biz linq kullanmayı bilmiyorsak şu şekilde yaparız  
            //    if (product.UnitPrice>5000 && product.UnitsInStock>3)
            //    {//ama biz böyle yaptığımız zaman program bütün her yeri tarayacak fiyatı 8kdan az varmı diye bakacak varsa yazacak
            //     //yoksa yazmayacak işte bunun yerine LİNQ kullanılır
            //        Console.WriteLine(product.ProductName);
            //    }
            //}
            var result = products.Where(p=>p.UnitPrice>5000 && p.UnitsInStock>3);//usteki algoritmik sistem yerine bukadar basit linq kullandık
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId{ get; set; }
        public string CategoryName { get; set; }
    }
}
