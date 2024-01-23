namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataErişim dataErişim = new DataErişim(new OracleVeriDeposu());
     
            dataErişim.Okuma();
            dataErişim.Sil();
            dataErişim.Güncelle();
            dataErişim.Yaz();
        }
    }


    public class  DataErişim
    {
        public DataErişim(IVeriDeposu vD)
        {
            VD = vD;
        }

        public IVeriDeposu VD { get; set; }
        public void Okuma()=> VD.Oku();
        public void Yaz() => VD.Yaz();
        public void Sil() => VD.Sil();
        public void Güncelle() => VD.Güncelle();
    }
    public interface IVeriDeposu

    {
        void Oku();
        void Yaz();
        void Sil();
        void Güncelle();
    }

    public class OracleVeriDeposu : IVeriDeposu
    {
        public void Güncelle()
        {
            Console.WriteLine("oracle güncelleme");
        }

        public void Oku()
        {
            Console.WriteLine("oracle okuma");
        }

        public void Sil()
        {

            Console.WriteLine("oracle silme");
        }

        public void Yaz()
        {
            Console.WriteLine("oracle yaz");
        }
    }
    public class MySqlVeriDeposu : IVeriDeposu
    {
        public void Güncelle()
        {
            Console.WriteLine("mysql güncelleme");
        }

        public void Oku()
        {
            Console.WriteLine("mysql okuma");
        }

        public void Sil()
        {

            Console.WriteLine("mysql silme");
        }

        public void Yaz()
        {
            Console.WriteLine("mysql yaz");
        }
    }


}
