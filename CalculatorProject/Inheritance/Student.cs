using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class Student : NttDataBase
    {
        public string Name;
        public string Surname;
        public DateTime Birthday;
        public Address Address;
        
        public Student(string name, string surname, DateTime birthday, Address address)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Address = address;
        }
    }
}
