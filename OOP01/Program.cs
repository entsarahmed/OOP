using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Calculator calc1 = new Calculator();  //Instance from Object
            //Console.WriteLine(calc1.Name);

            //Console.WriteLine(Calculator.Name);
            //int result = Calculator.AddNumbers(5,10);
            //Console.WriteLine(result);
            Car.NumberOfCalls = 3;

            Car car01 = new Car();
            Car car02 = new Car();
            Car car03 = new Car();


            // Instance for the first time only
            //Access Static Member (Fields or Methods)

        }


    }
   //Static Types   ==> Among Access Modifier and Class
   //Static Class => No instance -- No Create Object   
   //It's Necessary All Members to be Static
   //You can enable direct Access without create object (instance) Across Class Name itself
   //you can call Method without object

    public static class Calculator
    {
        public static string Name = "Arithmetic";
        public static int AddNumbers(int a, int b) 
        { 
        return a + b;
        }
    }

    //Static Class  ---- Static Field ----- Static Constructor ----- Static Method 

    //Static Constructor ==> No Access Modifier
    public class Car
    {
        public static int NumberOfCalls = 0; // throw object not arrived for static field
        public Car()  // Constructor -- make calling first what work instance or create object 
        {
            Console.WriteLine("Normal Constructor Calls");
        }

        static Car()
        {
            Console.WriteLine("Static Constructor Calls");
        }
    
        // No Use None Static Field inside Static Method
        //Static Talk Static
    public static void Drive()
        {
            Console.WriteLine(NumberOfCalls);
        }
    }

}
