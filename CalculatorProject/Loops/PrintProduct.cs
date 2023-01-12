using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class PrintProduct
    {
        public static List<Product> products = new List<Product>();

        public static void CreateListProduct()
        {
            var potatoes = new Product
            {
                Id = 1,
                Name = "Patatas",
                Price = 24.56f
            };
            products.Add(potatoes);

            var oil = new Product
            {
                Id = 2,
                Name = "Aceite",
                Price = 37.27f
            };
            products.Add(oil);

            var game = new Product
            {
                Id = 3,
                Name = "Juego",
                Price = 39.99f
            };
            products.Add(game);

            var shoes = new Product(4, "Zapatos", 20.99f);
            products.Add(shoes);
        }

        public static List<Product> GetProductsGreaterThan30WithWhile()
        {
            var productsGreaterThan30 = new List<Product>();
            int i = 0;
            while (i < products.Count)
            {
                if (products[i].Price>30) { 
                    productsGreaterThan30.Add(products.ElementAt(i));
                }
                i++;
            }
            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30WithFor()
        {
            var productsGreaterThan30 = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price>30) { 
                    productsGreaterThan30.Add(products.ElementAt(i));
                }
            }
            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30WithForEach()
        {
            var productsGreaterThan30 = new List<Product>();

            foreach (var product in products)
            {
                if (product.Price > 30f)
                {
                    productsGreaterThan30.Add(product);
                }
            }
            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30WithLinQ()
        {
            IEnumerable<Product> productsGreaterThan30 =
                from product in products
                where product.Price > 30f
                select product;
            return productsGreaterThan30.ToList();
        }
    }
}
