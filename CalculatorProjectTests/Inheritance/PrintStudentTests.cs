using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance.Tests
{
    [TestClass()]
    public class PrintStudentTests
    {
        [TestMethod()]
        public void SearchStudentTest()
        {

            Student st1 = new Student("Juan", "Sanchez", DateTime.Parse("1960 / 10 / 6"), new Address("Lucera", "Barcelona", "Barcelona"));


            Student st2 = new Student("Sofia", "Garcia", DateTime.Parse("1981 / 4 / 18"), new Address("Alcala", "Madrid", "Madrid"));


            Student st3 = new Student("Samuel", "Perez", DateTime.Parse("1998 / 7 / 14"), new Address("Alcala", "Madrid", "Madrid"));
            List<Student> students = new List<Student>();
            students.Add(st1);
            students.Add(st2);
            students.Add(st3);

            Assert.IsTrue(PrintStudent.SearchStudent(students).Count == 1);
            Assert.IsTrue(PrintStudent.SearchStudent(students)[0].Name.Equals("Sofia"));
        }
    }
}