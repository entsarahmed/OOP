using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IShape rec1 = new Rectangle();
            IShape c1 = new Circle();

            rec1.CalculateArea();
            c1.CalculateArea();

        }
    }

   
    // Contruct >>>>>>>>> Interface  >>>> Abstraction
    public interface IShape // is a code contruct or signature --> Write inside interface signature for property or signature for Method or Default Implemented property or  Default Implemented Method or signature for Method
        // can't create object ==> Just Only Stucture
        //Default Access Modifier ==> public
    {
        double CalculateArea();   // Method Signature
    }
   

    //Rectangle, Circle, Square 

    public abstract class Shape
    {
        public abstract double CalculateArea();
        //Complete Method
        public string GetName()
        {
            return "Rec";
        }
    }

    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        double IShape.CalculateArea()
        {
            return Length * Width;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double CalculateArea()
        {
            return Radius * Radius * 3.14;
        }
    }
}
