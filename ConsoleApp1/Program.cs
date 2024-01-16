using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rk}kx

            

         
           
          
        }


        public class Günlük
        {
            private string _content;
            public int Id { get; set; }
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


    }
}
