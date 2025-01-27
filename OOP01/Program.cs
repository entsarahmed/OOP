using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ClothingShop c1 = new ClothingShop();
            c1.Open();
            c1.CloseTheStore();

            FoodShop f1 = new FoodShop();
            f1 .Open();
             Shop s = new ClothingShop ();

        }
    }

    abstract class Shop  //Abstract => Not Fully Implemented with future class to come in future to complete this class
        //  is a container with common code among classes
        // can't create object from Abstract Class
    {
        public abstract void Open();  //Abstract Method 

        public void CloseTheStore()
        {
            Console.WriteLine("Store closed");
        }
    }

    class ClothingShop : Shop
    {
        public override void Open()
        {
            Console.WriteLine("Clothing shop open");
        }

        public void SellJeans()
        {
            Console.WriteLine("Clothing shop open");
        }
    }

    class FoodShop : Shop
    {
        public override void Open()
        {
            Console.WriteLine( " Food shop open");
        }
    }
}
