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

        [DataRow(3,3,6)]
        [DataRow(4,4,8)]
        [DataTestMethod]
        public void AddTest(int num1, int num2, int result)
        {
            Assert.IsTrue(calculator.Add(num1, num2) == result);
        }

        [DataRow(4, 3, 1)]
        [DataRow(6, 4, 2)]
        [DataTestMethod]
        public void SubstractTest(int num1, int num2, int result)
        {
            Assert.IsTrue(calculator.Substract(num1, num2) == result);
        }

        [DataRow(6, 2, 12)]
        [DataRow(5, 5, 25)]
        [DataTestMethod]
        public void MultiplyTest(int num1, int num2, int result)
        {
            Assert.IsTrue(calculator.Multiply(num1, num2) == result);
        }

        [DataRow(6, 3, 2)]
        [DataRow(40, 4, 10)]
        [DataTestMethod]
        public void DivideTest(int num1, int num2, int result)
        {
            Assert.IsTrue(calculator.Divide(num1, num2) == result);
        }
    }
}