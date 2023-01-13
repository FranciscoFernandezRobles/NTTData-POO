using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlandePensiones
{
    public class Person
    {
        public int BaseImponible { get; set; }
        public int PlanPensionesPersonaFisica { get; set; }
        public int PlanPensionesEmpresa { get; set; }

        public Person() { }

        public Person(int baseimponible, int planPensionesPersonaFisica, int planPensionesEmpresa) {
            baseimponible = BaseImponible;
            planPensionesPersonaFisica= PlanPensionesPersonaFisica;
            planPensionesEmpresa= PlanPensionesEmpresa;
        
        }

    }
}
