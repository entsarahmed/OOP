using System.Runtime.InteropServices;

namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**** OOP Principles
            //- Abstraction
            //- Polymorphism
            //- Inheritance
            //- Encapsulation

            Person person01 = new Person();

            person01.Name = "Ali";

            person01.Age = 15;

            Console.WriteLine(person01.Name);
            Console.WriteLine(person01.Age);
           
        }


    }

    class Person
    {
        //Binding & hiding

        private string _name;


        public void Talk()
        {

        }

        public string Name
        {
            //Logic
            get
            { 
                return _name; 
            }
            set {
                if ( value == "Ali")
                {
                    Console.WriteLine("can't set nan with Ali, Try another Name");
                }
                else
                {
                    _name = value;
                }
            }
        }


        //Automatic Property
        public int Age
        {
            get;
            set;
        }

    }




}
