using System.Collections.Specialized;
using static ConsoleApp11.Program;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { -2,0,0,0,-10,-11,-114,-2,-5,-33,-1,0,345, 456,3,7,41, 76, 23, 1, 2, 6, 8, };



            var result = Prinf(arr, SıralaTipi.Artan, SayıTür.Tek, İşaret.Negatif);


            foreach (var item in result.ToList())
            {
                Console.Write(item+ " - ");
            }

        }
        public static int[] Prinf(int[] arr, SıralaTipi st, SayıTür tür, İşaret x)
        {
            var resultArr = new int[arr.Length];

            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (x == İşaret.Pozitif)
                {

                    if (arr[i] > 0)
                    {
                        resultArr[j] = arr[i];
                        ++j;
                    }

                }

                if (x== İşaret.Negatif)
                {
                    if (arr[i] < 0)
                    {
                        resultArr[j] = arr[i];
                        ++j;
                    }
                }


            }

            var resultArr2 = new int[arr.Length];
            for (int i = 0,j=0; i < resultArr2.Length; i++)
            {

                if (tür == SayıTür.Çift)
                {

                    if (resultArr[i] % 2 == 0)
                    {
                        resultArr2[j] = resultArr[i];
                        ++j;
                    }

                }

                if (tür == SayıTür.Tek)
                {

                    if (resultArr[i] % 2 != 0)
                    {
                        resultArr2[j] = resultArr[i];
                        ++j;
                    }

                }

            }


            if (st == SıralaTipi.Artan)
            {
                Array.Sort(resultArr2);
            }
            else
            {
                Array.Sort(resultArr2);
                Array.Reverse(resultArr2);
            }
            var count = 0;
            foreach (var item in resultArr2)
            {
                if (item == 0)
                    ++count;
            }
            var newArr = new int[resultArr2.Length - count];


            for (int i = 0,j=0;i<resultArr2.Length;i++)
            {
                if (resultArr2[i]!= 0)
                {
                    newArr[j] = resultArr2[i];
                    ++j;
                }
            }


            return newArr;
        }

    }

    public enum SıralaTipi : int
    {
        Artan = 1,
        Azalan = 2
    }
    public enum SayıTür : int
    {
        Çift = 1,
        Tek = 2
    }
    public enum İşaret : int
    {
        Pozitif = 1,
        Negatif = 2
    }


}
