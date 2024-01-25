using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Security.Principal;
using System.Text.Json;

namespace ATM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hesap []hesaplar = new Hesap[3]
            //    {

            //        new(){Id=1,Bakiye=100,Pass=123},
            //        new(){Id=2,Bakiye=200,Pass=456},
            //        new(){Id=3,Bakiye=300,Pass=789}
            //    };


            //var data = JsonSerializer.Serialize(hesaplar);

            //File.WriteAllText("datalar.json", data);


            var result = Login(2, 456);


        
        }

        public static bool Login(int id,int pass )
        {

            //tüm kullanıcıları  bul

            var data =  File.ReadAllText("datalar.json");


            var hesaplar = JsonSerializer.Deserialize<Hesap[]>(data);


            foreach (var item in hesaplar)
            {
                if (item.Id == id && item.Pass== pass)
                {
                    Console.WriteLine("kulanıcı bulundu oturum açılıyor");
                    return true;
                }
            }
            Console.WriteLine("hesap ıd veya şifre hatalı ");

            return false;
        }
   
    
    
    
    }




   


    public class Hesap
    {
        public int Id { get; set; }
        public int Pass { get; set; }
        public int Bakiye { get; set; }

    }
}
