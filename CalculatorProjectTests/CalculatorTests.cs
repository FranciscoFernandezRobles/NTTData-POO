using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [TestMethod()]
        public void AddTest()
        {
            Assert.IsTrue(calculator.Add(2, 2) == 4);
            Assert.IsFalse(calculator.Add(2, 2) == 3);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Assert.IsTrue(calculator.Substract(3, 2) == 1);
            Assert.IsFalse(calculator.Substract(3, 2) == 4);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.IsTrue(calculator.Multiply(4, 4) == 16);
            Assert.IsFalse(calculator.Multiply(8, 6) == 7);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.IsTrue(calculator.Divide(80, 2) == 40);
            Assert.IsFalse(calculator.Divide(60, 3) == 2);
        }
    }
}