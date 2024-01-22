namespace ConsoleApp7
{
    public class GünlükYazılar : KriptoluYazı
    {
        public int Id { get; set; }
        public DateTime OluşturmaTarihi { get; set; }

        public GünlükYazılar(int id, string içerik)
        {
            this.İçerik = içerik; this.Id = id;
            this.Id = id;
            OluşturmaTarihi = DateTime.Now;
        }


    }
}
