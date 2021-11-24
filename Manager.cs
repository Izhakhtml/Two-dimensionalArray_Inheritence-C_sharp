using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrayInheritance
{
    class Manager:Person
    {
        public string fName;
        public string lName;
        public int numberOfWorkers;
        public int[,] numbersOfClass;
        public Manager(string fName, string lName, int numberOfWorkers, int age, int phone, string name,int[,] numbersOfClass) : base(name, phone, age)
        {
            this.fName = fName;
            this.lName = lName;
            this.numberOfWorkers = numberOfWorkers;
            this.numbersOfClass = numbersOfClass;
        }
        public void GetTwoArray()
        {
            Random random = new Random();
            for (int i = 0; i < this.numbersOfClass.GetLength(0); i++)
            {
                for (int j = 0; j < this.numbersOfClass.GetLength(1); j++)
                {
                    int randomNumber = random.Next(5000, 10000);
                    this.numbersOfClass[i, j] = randomNumber;
                    Console.Write(this.numbersOfClass[i, j]);
                }
                Console.WriteLine();
            }

        }
        public void GetTwoArrayArgument(int num1,int num2)
        {
            Random random = new Random();
            
            this.numbersOfClass = new int[num1,num2];
            for(int i = 0; i <this.numbersOfClass.GetLength(0);i++)
            {
                for(int j = 0; j < this.numbersOfClass.GetLength(1); j++)
                {
                    int randomNumber = random.Next(5000, 10000);
                    this.numbersOfClass[i, j] = randomNumber;
                    Console.Write(this.numbersOfClass[i, j]);
                }
                    Console.WriteLine();
            }
                   
        }
        public void PrintDetails()
        {
           Console.WriteLine($"fName:{this.fName}\nlName:{this.lName}\nnumberOfWorkers:{this.numberOfWorkers}\nnumbersOfClass:{this.numbersOfClass}\n{base.GetString()} ");
        }
    }
}
