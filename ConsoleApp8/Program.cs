using System.Security.Cryptography;

namespace ConsoleApp8
{


    internal class Program
    {


        public static void Main()
        {


            Telefon telefon = new Telefon(new TurkTelekomKart());

         

        }
        

    }

    public interface ISimKart
    {
        public int Numara { get; set; }

        void Arama();
        void HücreselVeri();
        void MesajGönder();

        void ÇağrıCevapla();
    }

    public class Telefon
    {
        public Telefon(ISimKart sim)
        {
                Kart = sim; 
        }
        public ISimKart Kart { get; set; }



        public void Arama() => Kart.Arama();

        public void Mesaj() => Kart.MesajGönder();

        public void Cevapla() => Kart.ÇağrıCevapla();

        public void HücreselVeri() => Kart.HücreselVeri();
    }


    public class TürkCellKart : ISimKart
    {
        public int Numara { get;     set; }

        public void Arama()
        {
            Console.WriteLine(Numara+ " Türkcell üzerinden arama yapıyor");
        }

        public void HücreselVeri()
        {
            Console.WriteLine(Numara + " Türkcell üzerinden hücresel veri alıyor");
        }

        public void MesajGönder()
        {
            Console.WriteLine(Numara + " Türkcell üzerinden  mesaj Gönderiyor");
        }

        public void ÇağrıCevapla()
        {
            Console.WriteLine(Numara + " Türkcell üzerinden  çağrı cevaplıyor");
        }
    }

    public class VodafoneKart:ISimKart
    {
        public int Numara { get; set; }

        public void Arama()
        {
            Console.WriteLine(Numara + " Vodafone üzerinden arama yapıyor");
        }

        public void HücreselVeri()
        {
            Console.WriteLine(Numara + " Vodafone üzerinden hücresel veri alıyor");
        }

        public void MesajGönder()
        {
            Console.WriteLine(Numara + " Vodafone üzerinden  mesaj Gönderiyor");
        }

        public void ÇağrıCevapla()
        {
            Console.WriteLine(Numara + " Vodafone üzerinden  çağrı cevaplıyor");
        }
    }

    public class  TurkTelekomKart:ISimKart
    {
        public int Numara { get; set; }

        public void Arama()
        {
            Console.WriteLine(Numara + "  TurkTelekom üzerinden arama yapıyor");
        }

        public void HücreselVeri()
        {
            Console.WriteLine(Numara + "  TurkTelekom üzerinden hücresel veri alıyor");
        }

        public void MesajGönder()
        {
            Console.WriteLine(Numara + "  TurkTelekom üzerinden  mesaj Gönderiyor");
        }

        public void ÇağrıCevapla()
        {
            Console.WriteLine(Numara + "  TurkTelekom üzerinden  çağrı cevaplıyor");
        }
    }
}
