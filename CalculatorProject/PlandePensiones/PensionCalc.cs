using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlandePensiones
{
    public class PensionCalc
    {
        public double Desgravo(int baseImponible, int planPensionesPersonaFisica, int planPensionesEmpresa)
        {
            Calculator calculator = new Calculator();
            double desgravo=0;
            if (baseImponible > 0 && baseImponible <= 12499)
            {
                desgravo = calculator.Add(planPensionesEmpresa, planPensionesPersonaFisica) * 0.19;
            }

            else if (baseImponible >= 12500 && baseImponible <= 20199)
            {
                desgravo = calculator.Add(planPensionesEmpresa, planPensionesPersonaFisica) * 0.30;
            }

            else if (baseImponible >= 20200 && baseImponible <= 59999)
            {
                desgravo = calculator.Add(planPensionesEmpresa, planPensionesPersonaFisica) * 0.37;
            }

            else if (baseImponible >= 60000 && baseImponible <= 299000)
            {
                desgravo = calculator.Add(planPensionesEmpresa, planPensionesPersonaFisica) * 0.45;
            }

            else if (baseImponible >= 300000)
            {
                desgravo = calculator.Add(planPensionesEmpresa, planPensionesPersonaFisica) * 0.47;
            }
            return desgravo;
        }
    }
}
