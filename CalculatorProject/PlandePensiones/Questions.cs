using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlandePensiones
{
    public class Questions
    {
        public int PreguntaBase (int baseImponible) {
            Console.WriteLine("¿Cual es tu base imponible?");
            baseImponible = Convert.ToInt32(Console.ReadLine());
            return baseImponible;
        }

        public int PreguntaPersonaFisica(int planPensionesPersonaFisica)
        {
            Console.WriteLine("¿Cual es tu aportacion al plan de pensiones de persona fisica?");
            planPensionesPersonaFisica = Convert.ToInt32(Console.ReadLine());
            return planPensionesPersonaFisica;
        }

        public int PreguntaEmpresa(int planPensionesEmpresa)
        {
            Console.WriteLine("¿Cual es tu aportacion al plan de pensiones de empresa?");
            planPensionesEmpresa = Convert.ToInt32(Console.ReadLine());
            return planPensionesEmpresa;
        }
    }
}
