using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[4, 4];

            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = rnd.Next(1,10);

                    Console.Write(arr[i,j]+ " ");
                }
                Console.WriteLine();

            }


            Console.Write("bir kordinat giriniz örn:  2,1    : ");

            var kordinat = Console.ReadLine();

            //1 , 1

            var x = int.Parse( kordinat.Split(',')[0]);
            var y = int.Parse( kordinat.Split(',')[1]);

            // 3,3 
            //yukarı komşuluk
            var ust = 0;
            var alt = 0;
            var sol = 0;
            var sağ = 0;
            if (x-1 >=0 )
            {
                ust = arr[x - 1, y];
            }
            if (x+1<=3)
            {
                alt = arr[x+1,y];
            }
            if (y - 1 >= 0)
            {
                sol = arr[x, y-1];
            }
            if (y+1<=3)
            {
                sağ = arr[x, y+1];
            }




            Console.WriteLine();
            Console.WriteLine("sağ "+ sağ);
            Console.WriteLine("sol "+ sol);
            Console.WriteLine("ust  "+ ust);
            Console.WriteLine("alt  "+ alt);

            //aşağı komşuluk


        }
        public class Günlük
        {

            public Günlük()
            {
                    _ıd= new Random().Next(200,999999999);
            }
            private string _content;
            private int _ıd;
            public int Id { get { return _ıd; }  }
            public string Content
            {
                get
                {
                    return Decryption(_content);
                }
                set
                {
                    _content = Encryption(value);
                }
            }
            public DateTime AddedDate { get; set; }

            public void Display()
            {
                Console.WriteLine("id " + Id);
                Console.WriteLine("contennt :  " + Content);
                Console.WriteLine("AddedDate :  " + AddedDate.ToShortTimeString());
            }

            private  string Encryption(string str)
            {

                var temp = "";
                for (int i = 0; i<str.Length;i++)
                {
                    temp+= (Convert.ToChar(((int)str[i]) + 10)).ToString();
                }

                return temp;
            }
            private  string Decryption(string str)
            {

                var temp = "";
                for (int i = 0; i < str.Length; i++)
                {
                    temp += (Convert.ToChar(((int)str[i]) - 10)).ToString();
                }
                return temp;
            }

        }
        public class Test
        {
            public Test()
            {
                Id = new Random().Next(1, 2001);
            }

            public int Id { get; set; }

        }
    }
}
