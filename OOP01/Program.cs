using System.Runtime.InteropServices;

namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dog dog01 = new Dog();
            dog01.weight=100;
            dog01.name ="roy";
            dog01.Eat();

            Elephant e1 = new Elephant();
            e1.weight=1000;

            e1.Eat();
        }
    }

    // Base Class, Parent Class, Super Class 

    class Animal
    {
        public string name;
        public int weight;

        public virtual void Eat()
        {
            Console.WriteLine("Is eating ");
        }
    }
  
    //Derived Classes 

    class Dog : Animal
    {

        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        public void Bark()
        {
            Console.WriteLine("dog is barking");
        }

    }
    class Elephant : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Elephant is eating");
        }
        public void WalkingSlowly()
        {
            Console.WriteLine("dog is barking");
        }
        
    }

    //sealed  ==> أنا كده بفهم الديفلوبر اللى هيجى إن ممنوع يشتق أو يورث من ال class ده
    sealed class Garden //can't derive  From sealed type of "garden"  ==> No consider base class
    {//No Make Child class ==> protect special Architecture --> Increase Optimization or performance with class
        public int Area;
        public string Address;

    }
    class Garden02
    {
       

    }

}
