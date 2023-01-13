using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class PrintStudent
    {

        public static List<Student> SearchStudent(List<Student> students)
        {

            IEnumerable<Student> StudentGreaterThan30 =
                from student in students
                where (AgeCalc(student) > 30*365)
                && (student.Name.ToCharArray()[0] == 'S')
                &&(student.Address.city.Equals("Madrid"))
                select student;

            return StudentGreaterThan30.ToList();
        }

        public static int AgeCalc(Student student)
        {
            DateTime birthTime = new DateTime(student.Birthday.Year, student.Birthday.Month, student.Birthday.Day);
            DateTime actualTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            return (actualTime - birthTime).Days;
        }
    }
}
