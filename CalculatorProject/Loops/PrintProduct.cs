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
        }

        public static List<Product> GetProductsGreaterThan30WithWhile()
        {
            var productsGreaterThan30 = new List<Product>();
            productsGreaterThan30 = products;
            int i = 0;
            while (i < productsGreaterThan30.Count && productsGreaterThan30[i].Price<30)
            {
                    productsGreaterThan30.RemoveAt(i);
                i++;
            }
            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30WithFor()
        {
            var productsGreaterThan30 = new List<Product>();
            productsGreaterThan30 = products;
            for (int i = 0; i < productsGreaterThan30.Count && productsGreaterThan30[i].Price<30; i++)
            {
                    productsGreaterThan30.RemoveAt(i);
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
