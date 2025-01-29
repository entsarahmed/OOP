using System.IO;

namespace OOP01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Read File  - 2 Ways ? the first way is the best?

            /*   StreamReader Sr = new StreamReader(@"F:\route.net\course\C# Practice\Test.txt");

            //string line;

            //while( (line = Sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}*/

            /*  string[] result  = File.ReadLines(@"F:\route.net\course\C# Practice\Test.txt").ToArray<string>();
               foreach (var line in result) 
                   Console.WriteLine(line);*/

            #endregion


            #region Write New Log File in Document type of text?
            string FilePath = @"F:\route.net\course\C# Practice\newFile.txt";

            // 1.  select the store File lwrite in file line by line 
            /*StreamWriter writer = new StreamWriter(FilePath);
            for (int i = 0; i<5; i++)
                writer.WriteLine("File input Video");
            writer.Close();*/

            //2. big Text write  all it once only
            string contents = "\nNew Text 4";
            //File.WriteAllText(FilePath, contents);

           // File.AppendAllText(FilePath, contents);
            
            // Check on Exit file?
            if (File.Exists(FilePath))
                Console.WriteLine("File exist Already");




            #endregion


        }


    }
    // Files?
   //أزاى أقرأ فايل ؟
   // أول حاجة لازم أعرف مكانه فين
   //Stream ==> Collection of Binary Data ==> Flow From Data ==> Flow From Bytes

}
