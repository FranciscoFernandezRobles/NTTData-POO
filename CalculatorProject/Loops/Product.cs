using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public float Price { get; set; }

        //Crea el objeto sin parametros
        public Product()
        {

        }

        //Crea el objeto pasandole paranetros
        public Product(int id, string name, float price)
        {
            Name=name;
            Id=id;
            Price=price;
        }

        //Pasa el objeto a cadeba de texto
        public override string ToString()
        {
            return "Product: " + Name + ", " + Id + ", " + Price;
        }
    }
}
