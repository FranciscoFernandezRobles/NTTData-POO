using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.InterfaceExample.Vehiculo
{
    public class Camion : Vehiculo
    {
        public override void Arrancar() 
        {
            Console.WriteLine("Camion Arrancado");
        }

        public object Clone()
        {
            return new Camion();
        }

        public override void Parar()
        {
            Console.WriteLine("Camion Parado");
        }
    }
}
