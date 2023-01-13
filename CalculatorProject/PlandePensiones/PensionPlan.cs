using CalculatorProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlandePensiones
{
    public class PensionPlan
    {
        public static void Pension() {

            PensionCalc pensionCalc = new PensionCalc();
            Calculator calculator = new Calculator();
            Questions questions = new Questions();
            int baseImponible = questions.PreguntaBase(0);
            int planPensionesPersonaFisica = questions.PreguntaPersonaFisica(0);
            int planPensionesEmpresa = questions.PreguntaEmpresa(0);

            var person = new Person
            {
                BaseImponible = baseImponible,
                PlanPensionesPersonaFisica = planPensionesPersonaFisica,
                PlanPensionesEmpresa = planPensionesEmpresa
            };

            double desgravo = pensionCalc.Desgravo(baseImponible, planPensionesPersonaFisica, planPensionesEmpresa);
            Console.WriteLine("Tu desgravo es " + desgravo);
        }
    }
}
