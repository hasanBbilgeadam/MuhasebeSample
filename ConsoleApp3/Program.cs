using System.Net.Http.Headers;
using System.Xml;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //şifre 1234   public static 
            //bakiye 2500  public static 

            //veri girişlerinin hepsi kontrollü olmalı
            //hiçbir şekilde çökmemeli

            /*
             ATM UYGULAMASI

                //tek seferlik şifre soracak şifre doğru ise atm menüsü açılak
                // bu süreç 3 tekrarlansın 3 deneme sonunda hala doğru giriş olmaz ise çıkış yapılsın

                //1-para çekme
                    //çekilecek miktarı iste parayı ver
                    //bakiyeden parayı düş
                    //çekeceği para bakiyeden büyükse!!! uyar  tekrar iste
                //2- para ekleme
                    //ekleyeceği miktarı iste => geçersiz veri girişi durumunda uyar ver ve tekrar iste
                    //örn : 257 => 250 atm 5 lira ve bozuk para kabul etmiyor
                    //!!! 10 lira altında bir para yükleme yapılamaz

                //3- para gönder
                    //alıcı hesap numarası iste sayıdan oluşmalı 5 haneli olmalı yine veri girişi kontrol yap hatalı girişte tekrar iste ve uyarı ver
            //bakiye kontrol eğer giriş miktari uygunsa bakiyenden parayı
            //aksi takdirde uyar

                    
                //4- şifre değiştir 
                     //veri girişini kontrol et hatalı durumda uyar
                    //güncel şifresini iste eğer doğru girmiş ise
                    //yeni şifreyi iste şifreyi güncelle
                
               // 5- çıkış yapı seçtiyse iyi günler deyip kapat
            */
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("hasan baysal");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("hasan baysal");
              Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("hasan baysal");

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
