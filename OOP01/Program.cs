namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Access Modifier => Control visibility for Members

            // Classes, Members(Fields, Methods, Properties)

            //Public : Visibility Outside Class
            //Private : Within class

            //Default Access Modifier in class   => Private

            // internal , protected



        }


    }
     
   
    public class House
    {
        int Area;
        public int GetRooms()
        {
            Villa newVilla = new Villa();
            newVilla.GetRoomsVilla();
            return 3;
        }
    }


    
    public class Villa
    {     
        //Fields
        public int AreaVilla;

        //Method
        public int GetRoomsVilla()
        {
            return 3;
        }
    }
    
}
