using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Öğrenci
    {
        public string AdSoyad { get; set; }
        public int Numara { get; set; }
        public int Sınıf { get; set; }
        public char Şube { get; set; }
        public bool Cinsiyet { get; set; }
        public int Sınav1 { get; set; }
        public int Sınav2 { get; set; }
        public int Sınav3 { get; set; }
        public float Ortalama { get; set; }
        public String ÖğretmenKanaat { get; set; }


        public void ÖğrenciBilgiGetir()
        {
            Console.WriteLine("Ad Soyad :" + AdSoyad);
            Console.WriteLine("Numara :" + Numara);
            Console.WriteLine("Şube :" + Şube);
            Console.WriteLine("Sınıf :" + Sınıf);
            Console.WriteLine("Cinsiyet :" + (Cinsiyet?"Kadın":"Erkek"));
       
        }

        public void ÖğreciOrtalama()
        {
            var temp = (Sınav1 + Sınav2 + Sınav3)/ 3.0f;

            Ortalama = temp;

            //Console.WriteLine("Ortalama : "+ Ortalama);
        }


        public void KanaatEkle(string str)
        {
            ÖğretmenKanaat = str;

            Console.WriteLine("öğretmen kaanati");
            Console.WriteLine(ÖğretmenKanaat);

        }

    }
}
