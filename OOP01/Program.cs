using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var f = (int)DaysOfTheWeeks.Friday;
            int x = 5;
            var z = (DaysOfTheWeeks)x;

            Console.WriteLine(f);
            Console.WriteLine(z);

            string input = Console.ReadLine();
            int i = Convert.ToInt32(input);
            var enumInput = (TrafficLights)i;

            switch(enumInput)
            {
                case TrafficLights.Green:
                    Console.WriteLine("Go");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Go");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Go");
                    break;
                default:
                    Console.WriteLine("Ivalid number");
                    break;
            }
        }


    }
     
    //Enums => Enumeration --> ValueType - Collection of Constants -- contain Fixed Value Like days of week or Gender
    // Readabilty is very Easy => is consider integer values

    enum DaysOfTheWeeks
    {
        Monday, 
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum TrafficLights
    {
        Green = 1,
        Yellow,
        Red
    }

}
