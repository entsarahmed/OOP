using System.IO;


namespace OOP01
{
    internal class Program
    {
        //Object Intialization

        static void Main(string[] args)
        {

           // Rectangle rec1 = new Rectangle(10,20);

            Rectangle rec1 = new Rectangle()
            {
                Width = 10,
                Height = 20
            };

            rec1.Width =10;
            rec1.Height =20;

            // Console.WriteLine(rec1.CalculatePermiter());
            Console.WriteLine(rec1.CalculatePermetier());

            string x = "hello";
            string result = x.ToFirstUpper();
            Console.WriteLine(result);
            string m = "ali";
            m.ToFirstUpper().ToString();
            Console.WriteLine(m);


        }


    }

    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(int width, int height)
        {
        Width = width;
        Height = height;
        }
        public int CalculateArea()
        {
            return Width * Height;
        }
        public int CalculatePermiter()
        {
            return 2 * (Width + Height);
        }
    }
   
}


