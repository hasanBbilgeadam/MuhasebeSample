using System.Net.Http.Headers;
using System.Xml;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            //var arr = new int[6, 6];
            //Random rnd = new Random();
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        arr[i, j] = rnd.Next(1, 10);
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("toplam sonucu");
            //var result = SütünTopla(arr);

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}

            #endregion


            Random rnd = new Random();
            var hedefSaniye = rnd.Next(1, 15);

            Console.WriteLine("Oyun Başladı tam "+ hedefSaniye+" sonra bir tuşa basarsanız kazanırsınız");
            var FirstTime = DateTime.Now;

            var dummy = Console.ReadLine();
            var SecondTime = DateTime.Now;  

            var timeResult = SecondTime-FirstTime;

            var result = (int)timeResult.TotalSeconds;


            Console.WriteLine("hedef süre "+ hedefSaniye);
            Console.WriteLine("siz "+result+" saniye kadar sonra işlem yaptınız" );

            if (result==hedefSaniye)
            {
                Console.WriteLine("kazandınız");
            }
            else
            {
                Console.WriteLine("kaybettiniz");
            }

            //oyunu başlatmak için enter'a basınız
            // X saniye sonra bir tuşa bas ve enter'a bas
            //x random bir sayıdır 1,15 aralığında 

            //eğer kullanıcı tam olarak x'saniyede bu işlemi yapabilmiş ise
            //kazandın diyoruz
            //eğer başarmadı ise geçen süresi saniye bazında yazdır
            //hedef (x)10 sizin süreiniz 7 => kaybettiniz

            //DateTime time = DateTime.Now;   
            //DateTime timeSecond = DateTime.Now.AddMinutes(10);
            //var result =  timeSecond - time;
            //Console.WriteLine((int)result.TotalSeconds);


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
