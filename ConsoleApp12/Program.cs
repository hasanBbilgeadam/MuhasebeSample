using System.Reflection;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var konular = new Konut[]
            {
                new(Evtip.hVilla,EvDurumu.boş,SatışTipi.GKiralik,100,10,"ankara","sincan"),
                new(Evtip.hVilla,EvDurumu.boş,SatışTipi.GKiralik,100,10,"ankara","sincan"),
            };


            Emlakcı emlak = new();

            emlak.Konutlar = konular;


            emlak.EvArama(SatışTipi.GKiralik, "ankara", "sincan");

            Console.WriteLine("------------ ekledikten sonra ----------");
            emlak.KonutEkle(new(Evtip.hVilla, EvDurumu.boş, SatışTipi.GKiralik, 12, 23, "ankara", "sincan"));

            emlak.EvArama(SatışTipi.GKiralik, "ankara", "sincan");


            var id =  emlak.Konutlar[emlak.Konutlar.Length - 1].Id;
            Console.WriteLine("ev durumu değişti");
            emlak.Konutİşlem(id);

            emlak.EvArama(SatışTipi.GKiralik, "ankara", "sincan");




        }



    }

    public enum Evtip : int
    {
        villa = 1,
        daire = 2,
        hVilla = 3,
    }
    public enum SatışTipi : int
    {
        kiralık = 1,
        satılık = 2,
        GKiralik = 3,
    }
    public enum EvDurumu : int
    {
        dolu = 1,
        boş = 2,
        icra = 3
    }

    public class Konut
    {
        public Konut()
        {
            Random rnd = new Random();

            _id = rnd.Next(20, 201);
        }

        public Konut(Evtip evTip, EvDurumu evDurumu, SatışTipi satışTipi, int alan, int fiyat, string ıl, string ılçe) : this()
        {
            EvTip = evTip;
            EvDurumu = evDurumu;
            SatışTipi = satışTipi;
            Alan = alan;
            Fiyat = fiyat;
            Il = ıl;
            Ilçe = ılçe;
        }

        private int _id;
        public int Id { get { return _id; } }
        public Evtip EvTip { get; set; }
        public EvDurumu EvDurumu { get; set; }
        public SatışTipi SatışTipi { get; set; }
        public int Alan { get; set; }
        public int Fiyat { get; set; }
        public string Il { get; set; }
        public string Ilçe { get; set; }

    }

    public class Emlakcı
    {

        public Konut[] Konutlar { get; set; }


        public void KonutEkle(Konut konut)
        {

            var newArrr = new Konut[Konutlar.Length+1];

            for (int i = 0; i < Konutlar.Length; i++)
            {
                newArrr[i] = Konutlar[i];
            }
            newArrr[newArrr.Length - 1] = konut;

            Konutlar = newArrr;


        }
        public void Konutİşlem(int konutId)
        {

            foreach (var item in Konutlar)
            {
                if (item.Id == konutId)
                {
                    item.EvDurumu = EvDurumu.dolu;
                    return;
                }
            }
        }
        public void EvArama(SatışTipi st, string il, string ilçe)
        {

            foreach (var item in Konutlar)
            {
                if (item.SatışTipi == st && item.Il == il && item.Ilçe == ilçe)
                {
                    if (item.EvDurumu ==EvDurumu.boş)
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.Write(item.Id + "  " );
                        Console.Write(item.Il + "  " );
                        Console.Write(item.Alan + "  " );
                        Console.Write(item.Fiyat + "  " );
                        Console.Write(item.EvTip + "  " );
                        Console.Write(item.EvDurumu + "  " );
                        Console.Write(item.SatışTipi + "  " );
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------");
                    }
                }
            }

        }

    }
}
