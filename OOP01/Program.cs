using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Point02 point01 = new Point02(5,10);
            Point02 point011;
            Console.WriteLine(point01.x);
            point011 = point01;
            point01.x =30;
            Console.WriteLine(point011.x);


        }
    }

    // Struct => Structure --> ValueType -- Store Collection of Data
    // No support inheritance   --  high performance -- Support Inheritance

    // Data Types  
    //- Value Types  == > is very fast => location in Memory // Store in stack
    // (Simple Types - Enum Types - Struct Types - Nullable Types)   
    //- Reference Types //=> Store in stack and Heap
    //(Class Types - Interface Type - Array Types - Delegate Types)
    //- Pointer Types

    public struct Point02
    {
        public int x;
        public int y;
        public Point02(int x, int y)
        {
            this.x= x;
            this.y=y;
        }
        public void MovePoint()
        {
            x=x+1;
        }
    }

    public class Point03
    {

    }


}
