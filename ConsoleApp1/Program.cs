using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
