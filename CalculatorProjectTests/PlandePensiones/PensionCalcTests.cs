using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.PlandePensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlandePensiones.Tests
{
    [TestClass()]
    public class PensionCalcTests
    {
        PensionCalc pensionCalc = new PensionCalc();

        [DataRow(10000, 500, 500, 190)]
        [DataRow(15000, 500, 500, 300)]
        [DataRow(30000, 500, 500, 370)]
        [DataRow(66000, 500, 500, 450)]
        [DataRow(700000, 500, 500, 470)]
        [DataTestMethod]
        public void DesgravoTest(int baseImponible, int planPensionesPersonaFisica, int planPensionesEmpresa, double desgravo)
        {
            Assert.IsTrue(pensionCalc.Desgravo(baseImponible, planPensionesPersonaFisica, planPensionesEmpresa) == desgravo);
        }
    }
}