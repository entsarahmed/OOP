using System.Runtime.InteropServices;

namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Animal dog = new Dog();   //Reference from Parent refer to object from child ==> run Principle Polymorphism 
            dog.MakeSound();
            Animal cat = new Cat();
            cat.MakeSound();


        }
    }

    // Base Class, Parent Class, Super Class 

    /// Polymorphism  => Support Inheritance

    // Poly = Multiple - Many   * Morphism => Form
    // Multiple Forms  =>أشكال متعدده => أعامل objectمختلفة على أنها نفس  object

    class Animal //Base Class
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Make Sound");
        }
       
    }
    class Dog : Animal
    {
      public override void MakeSound()
        {
            Console.WriteLine("Dog Make Sound");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat Make Sound");
        }
    }
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)   //Change Signature with Method
        {
            return a + b;
        }
        public double Add(double a, double b, double c)   //Change Signature with Method
        {
            return a + b + c;
        }
    }

}
