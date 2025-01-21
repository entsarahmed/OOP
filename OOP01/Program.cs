namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dry ==> Don't Repeat Your Self


            // Procedural Programming ===> البرمجه الاجرائيه يعنى لو فى سطور بتنفذها ورا بعض بترجع تتابع علشان تصلح الحته دى  تتابع من السطور البرمجية بنفذها سطر سطر  

            //Class: ---> is a bluePrint or Template which is created the object based on it ."القالب اللى هحط فيها موصفات العربية اللى بالنيابة عنها اقدر انشئ كائن من خلاله"



            // Car 1
            string CarModel = "Toyota";
            int CarYear = 2002;
            double CarPrice = 100000;

            //Car 2
            string CarModel2 = "Honda";
            int CarYear2 = 2010;
            double CarPrice2 = 500000;

            //Problems 
            // 1. Repeat your self
            //2. No Organize 
            //3. No Structure
            //4. No Maintainable


            //Using OOP

            //1. Create Class Car

            //2. Create the Object from Class Car

            //Object  => Instance of the Class(نموذج  من ال class ده)

            Car car01 = new Car();   //New Object 

            car01.CarModel = "Toyota";
            car01.CarYear = 2002;
            car01.CarPrice = 100000;

            Car car02 = new Car();   //New Object 

            car02.CarModel = "Honda";
            car02.CarYear = 2010;
            car02.CarPrice = 500000;

            // Make Clear Structure
            // Apply Dry => Don't Repeat Your Self
            //Resizability





        }
    }
    // New Class

    public class Car
    {
        //Fields  -- Attributes ==> المواصفات اللى موجوده فى ال class
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public double CarPrice { get; set; }
        public string Color { get; set; }

        // طب أزاى هعمل عربية جديدة هنا بقى يجى دور ال  ==>  object 
    }


}
