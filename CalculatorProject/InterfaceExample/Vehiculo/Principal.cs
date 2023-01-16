using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.InterfaceExample.Vehiculo
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            //Polimorfismo de interfaces
            IVehiculo coche = new Coche();
            coche.Arrancar();
            coche.Parar();
            //coche.Clone(); No se puede acceder

            ICloneable cloneable = new Coche();
            cloneable.Clone();

            //Polimorfismo de clases
            Vehiculo vehiculo = new Camion();
            vehiculo.Arrancar();
            vehiculo.Parar();
            vehiculo.Test();

            Console.ReadKey();
        }
    }
}
