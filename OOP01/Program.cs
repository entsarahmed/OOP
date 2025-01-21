namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Create Object 
           Car toyota = new Car();
            toyota.Color = "Red";
            toyota.Model = "Toyota";
            toyota.price = 100;

            Car ford = new Car();

            ford.Start();

            ford.Stop();

            ford.Year = 100;
        }
    }
     

    // Public ==> AccessModifier -- with Select Visiability for class
    public class Car
    {

        // Class Members 
        //1. Fields => (color, model, price)
        //2. Methods (behaviours .. Move .. Stop .. Brake)
        //3. Properties (Smart Fields  - Can control data)

        //- Define Field
        public string Color;
        public string Model;
        public double price;

        private int _Year; //private field


        //Methods 
        public void Start()
        {

        }

        public void Stop()
        {
            //Logic
            Console.WriteLine("The Car stopped");
        }

        //Properties (Controlled  Access)
        public int Year
        {
            get
            {
                if(_Year == 0)
                {
                    return 0;
                }
                return _Year; //Arrive for private field
            }

            set
            {         
                // Logic

                _Year = value;
            }

        }


    }

}
