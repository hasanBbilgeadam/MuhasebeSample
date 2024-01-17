using System.Net.Http.Headers;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[6, 6];
            Random  rnd = new Random(); 
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = rnd.Next(1,10);
                    Console.Write(arr[i,j]+ " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("toplam sonucu");
            var result =  SütünTopla(arr);

            for (int i = 0; i < 6; i++)
            {
                Console.Write(result[i]+ " ");
            }

        }

        public static int[] Büyüt(int []arr)
        {
            //1 2 3 arr
            //1 2 3 0
            int[] newArr = new int[arr.Length+1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;  

        }


        public static int[] SütünTopla(int[,] arr)
        {
            var temp = 0;
            var resultArr = new int[6];
            for (int i = 0; i < 6; i++)
            {
                temp = 0;
                for (int j = 0; j < 6; j++)
                {
                    temp += arr[j, i];
                }
                resultArr[i] = temp;
                
            }

            return resultArr;

        }
    }
}
