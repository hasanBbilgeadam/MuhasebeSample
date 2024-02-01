using System.ComponentModel;
using System.Drawing;
using System.Net.WebSockets;

namespace ConsoleApp18
{
    internal class Program
    {
         public enum config 
        {
            bc = 1,
            fc = 2,
        }
        static void Main(string[] args)
        {

            

            FileStream file = new("deneme.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);



            StreamReader streamReader = new StreamReader(file);


            var result =  streamReader.ReadLine();


            var line = streamReader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);

               line = streamReader.ReadLine();  
            }


        }


        static void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        Console.WriteLine(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
