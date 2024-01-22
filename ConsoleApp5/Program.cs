using ConsoleApp4;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OyunKaset oyun1 = new OyunKaset() { OyunAdı="oyun 1"};
            OyunKaset oyun2 = new OyunKaset() { OyunAdı="oyun 2"};
            OyunKaset oyun3 = new OyunKaset() { OyunAdı="oyun 3"};

            Atari atari = new Atari();
            atari.Oyunlar = new OyunKaset[3] {oyun1, oyun2, oyun3};

          

            atari.OyunBaşlat("oyun 1");

            Thread.Sleep(5000);


            atari.OyunBitir();


            atari.OyunBaşlat("oyun 1");
            Thread.Sleep(2000);

            atari.OyunBitir();

        }   
    }

    public class OyunKaset
    {
        private int süre;
        public string OyunAdı { get; set; }
        public int ToplamSüreDakika { get { return süre; }   }

        private DateTime First;
        
        public void Başla()
        {
            First = DateTime.Now;
        }
        public void Bitir()
        {

            var time =  DateTime.Now - First;

            süre += (int)time.TotalSeconds;

        }

    }

    public class Atari
    {

        public OyunKaset[] Oyunlar { get; set; }

        private OyunKaset _oyun;

        public void OyunArama(string ad)
        {
            foreach (var item in Oyunlar)
            {
                if (item.OyunAdı == ad)
                {
                  
                    Console.WriteLine(" oyun adı "+item.OyunAdı);
                    Console.WriteLine(" toplama oynama süresi "+item.ToplamSüreDakika);

                    return;
                }
            }

            Console.WriteLine("ilgili oyun bulunamadı");

        }


        public void OyunBaşlat(string ad)
        {
            foreach(var item in Oyunlar)
            {
                if (item.OyunAdı == ad)
                {
                    _oyun = item;
                    _oyun.Başla();
                    Console.WriteLine(item.OyunAdı + " oyunu başladıııııı !!!!");
                    return;
                }
            }
        }
        public void OyunBitir()
        {
            _oyun.Bitir();
        
            Console.WriteLine(" ");
            Console.WriteLine(_oyun.OyunAdı +" oyunu kapandııııııı toplam süre değişti " +_oyun.ToplamSüreDakika );
            Console.WriteLine();
            _oyun = null;
        }

    }


  
}
