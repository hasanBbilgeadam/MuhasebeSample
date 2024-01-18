using System.Reflection.Metadata;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

                 string arr [3,3] => hepsinin içini * ile doldur
                 * * *
                 * * *
                 * * * =====> başlangıç hali

                 kullanıcıdan bir kordinat al eğer boş ise oraya x ekle
                  akabinde 
                 bilgisayar random boş olan bir kordinata O eklesin
            ve tüm kordinatlara x veya o ile oldana kadar bu işlem devam etsin




             */

            string[,] arr = new string[3, 3];
            for (int k = 0; k < arr.GetLength(0); k++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[k, j] = "*";
                   
                }
              
            }

            int i =0; 

            while (i<9)
            {

                

                Console.Write("kordinat gir ");
                var kullaniciKordinat = Console.ReadLine();

                var xK =int.Parse( kullaniciKordinat.Split(',')[0]);
                var yK = int.Parse(kullaniciKordinat.Split(',')[1]);
                arr[xK, yK] = "O";
                ++i;

                Console.Clear();
                PrintArr(arr);


                if (i == 9)
                {
                    Console.WriteLine("oyun bitti");
                    break;
                }

                Console.WriteLine("bilgisayar oynuyor...");
                Thread.Sleep(1000);
                var control = true;
                Random rnd = new();
                Console.Clear();
                while (control)
                {

                  

                    var cX = rnd.Next(0,3);
                    var cY = rnd.Next(0,3);

                    if (arr[cX,cY] =="*")
                    {
                        arr[cX, cY] = "X";
                        control = false;    
                    }

                }
                ++i;

                PrintArr(arr);
                Console.WriteLine();


            }

            
        }

        public static void PrintArr(string[,] arr)
        {
            for (int k = 0; k < arr.GetLength(0); k++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                 
                    Console.Write(arr[k, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
