namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
          House house = new House(); //Object Creation / Instantion

           // House house01 = new House(10000);

            //  Console.WriteLine(house01.Price);

            //  Constructor ==> المنشئ الذى ينشئ الاشياء

            //  Console.WriteLine(house.Color);

            House house05 = new House(); //Object Creation / Instantion

            Console.WriteLine(house05);

        }


    }
     
    public  class House
    {
        public string Color;
        public int Price;
        public int NumberOfRooms;

        //1. Default Constructor

        //2. parameterized Constructor


        //1. Default Constructor

        //Constructor Chaining 
        public House() : this(10000)
        {
            NumberOfRooms = 3;
        }


        //2. Parameterized Constructor ==> Take Parameteries
        public House(int price)
        {
            Price = price;
        }



    }
    


    
    
}
