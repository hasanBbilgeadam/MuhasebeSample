namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Savaşcı savaşcı = new Savaşcı() { İsim = "s1" };
            Savaşcı savaşcı2 = new Savaşcı() { İsim = "s2" };
            Okçu okçu1 = new Okçu() { İsim = "s3" };


            OyunAlanı oyunAlanı = new OyunAlanı();

            oyunAlanı.Oyuncular = new Ikarakter[3] { savaşcı,savaşcı2,okçu1};

            //oyunAlanı.SavaşYap(savaşcı2, okçu1);

            oyunAlanı.OyuncuBilgi("s3");


        }
    }
    public interface Ikarakter
    {
        int SaldırıYap();
        public int Can { get; set; }
        public String İsim { get; set; }
    }

    public class Savaşcı : Ikarakter
    {
        public int Can { get; set; } = 70;
        public string İsim { get; set; }

        public int SaldırıYap()
        {
            Random rnd = new Random();
            return rnd.Next(7, 19);

        }
    }
    public class Okçu : Ikarakter
    {
        public int Can { get; set; } = 80;
        public string İsim { get; set; }

        public int SaldırıYap()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);

        }
    }
    public class Büyücü : Ikarakter
    {
        public int Can { get; set; } = 60;
        public string İsim { get; set; }

        public int SaldırıYap()
        {
            Random rnd = new Random();
            return rnd.Next(5, 21);

        }
    }


    public class OyunAlanı
    {

        public Ikarakter[] Oyuncular { get; set; }
        public void SavaşYap(Ikarakter a, Ikarakter b)
        {

            for (int i = 0; i < 10; i++)
            {

                b.Can = b.Can - a.SaldırıYap();
                Console.WriteLine(b.İsim+ " can değeri "+ b.Can);
                if (b.Can <= 0)
                {
                    Console.WriteLine(b.İsim + " kaybetti");

                    return;
                }

                a.Can = a.Can - b.SaldırıYap();
                Console.WriteLine(a.İsim + " can değeri " + a.Can);
                if (a.Can <= 0)
                {
                    Console.WriteLine(a.İsim + " kaybetti");

                    return;

                   
                }
                Console.WriteLine("---------------------------------");

                Thread.Sleep(700);

            }


            Console.WriteLine("kazanan yok");
        }
        public void OyuncuBilgi(string s)
        {
            foreach (var item in Oyuncular)
            {
                if (item.İsim == s)
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine("isim :" + item.İsim);
                    Console.WriteLine("can : " + item.Can);

                    if (item is Okçu)
                    {
                        Console.WriteLine("sınıfnı okçu");
                    }
                    if (item is Savaşcı)
                    {
                        Console.WriteLine("sınıfnı Savaşçı");
                    }
                    if (item is Büyücü)
                    {
                        Console.WriteLine("sınıfı büyücü");
                    }

                    Console.WriteLine("------------------");

                    return;
                }
            }

            Console.WriteLine("böyle bir oyuncu bulunamadı");
        }

    }
}
