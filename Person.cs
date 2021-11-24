using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrayInheritance
{
    class Person
    {
        public string name;
        public int age;
        public int phone;
        public Person(string name,int age,int phone)
        {
            this.name = name;
            this.age = age;
            this.phone = phone;
        }
        public Person() { }
        public string GetString()
        {

            return $"NAME:{this.name}\nAGE:{this.age}\nPHONE:{this.phone}";
               
        }
    }
}
