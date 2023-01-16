using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Student student= new Student();
            student.Name = "Pepe";

            //BOxing and Unboxing
            arrayList.Add(student);

            Console.WriteLine(((Student)arrayList[0]));

            //arrayList[0].Name error

            Object obj = new Student(); //Boxing 
            ((Student)obj).Name = "Alberto"; //Unboxing
            Console.WriteLine(((Student)obj).Name);
        }
    }
}
