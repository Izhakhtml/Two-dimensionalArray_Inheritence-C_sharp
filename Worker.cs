using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrayInheritance
{
    class Worker:Person
    {
        public string fName;
        public string lName;
        public int numberClass;
        public Worker(string fName, string lName, int numberClass, int age, int phone, string name):base(name,phone,age)
        {
            this.fName = fName;
            this.lName = lName;
            this.numberClass = numberClass;
        }
        public Worker() { }
        public void PrintDetails()
        {
        Console.WriteLine($"fName:{this.fName}\nlName:{this.lName}\nclass:{this.numberClass}\n{base.GetString()} ");
        }
    }
}
