using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

        }
    }


    //Assosiation (uses a) LifeTime
    //Aggregation (has a) 1 to  1 ....1 to many
    //Composition (owns a)   ==> Strong Relationship

    class Department
    {
        public string Name { get; set; }
    }
    class Company
    {
        public string Name { get; set; }
        public Department Department { get; set; }   //Aggregation (has a)
    }
        class Employee
    {
        public string Name { get; set; }
        public Department Department { get; set; }  //Assosiation (uses a)
    }


    class Engine
    {
        public string Model { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public Engine Engine { get; set; } // Composition (owns  a)  
    }
}
