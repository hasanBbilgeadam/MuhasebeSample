using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {





            #region c1 şirket oluşurma personellerini oluşturma


            Personel a1 = new Personel() { Ad = "personel 1", ID = 1, Maaş = 10 };
            Personel a2 = new Personel() { Ad = "personel 2", ID = 2, Maaş = 12 };
            Personel a3 = new Personel() { Ad = "personel 3", ID = 3, Maaş = 20 };
            Personel a4 = new Personel() { Ad = "personel 4", ID = 4, Maaş = 11 };

            Şirket company1 = new Şirket();
            company1.CId = 123;
            company1.ŞirketAdı = "c1 ";

            company1.Personels = new Personel[4];

            company1.Personels[0] = a1;
            company1.Personels[1] = a2;
            company1.Personels[2] = a3;
            company1.Personels[3] = a4;

            #endregion

            #region c2 şirket oluşturma ve perosnellerini oluşturma

            Personel c2a = new Personel() { ID = 12, Ad = " c2a", Maaş = 30 };
            Personel c2b = new Personel() { ID = 123, Ad = " c2b", Maaş = 32 };
            Personel c2c = new Personel() { ID = 1234, Ad = " c2c", Maaş = 34 };
            Personel c2d = new Personel() { ID = 12345, Ad = " c2d", Maaş = 44 };

            Şirket company2 = new Şirket()
            {

                CId = 455,
                ŞirketAdı = "c2",
                Personels = new Personel[] { c2a, c2b, c2c, c2d }

            };


            #endregion

            Muhasebe muhasebe = new Muhasebe();
            muhasebe.Şirketler = new Şirket[2];



            muhasebe.Şirketler[0] = company1;
            muhasebe.Şirketler[1] = company2;





            //muhasebe.ListAllCompany();

            muhasebe.GetTotalSalaryByCID(455);
        }


        public static void SınıfListele(Öğrenci[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine("---------------------------------------------");
                Console.Write("adı soyad : " + item.AdSoyad);
                Console.WriteLine();
                Console.Write("sınav1 : " + item.Sınav1);
                Console.WriteLine();
                Console.Write("sınav2  : " + item.Sınav2);
                Console.WriteLine();
                Console.Write("sınav3  : " + item.Sınav3);
                Console.WriteLine();
                Console.Write("ortlama : " + item.Ortalama);
                Console.WriteLine();
                Console.Write("cinsiyet  : " + (item.Cinsiyet ? "kadın" : "erkek"));
                Console.WriteLine();
                Console.Write("sınıf  : " + item.Sınıf);
                Console.WriteLine();
                Console.Write("şube : " + item.Şube);
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();
            }
        }


    }

    public class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public int Maaş { get; set; }

    }
    public class Şirket
    {

        public int CId { get; set; }
        public string ŞirketAdı { get; set; }
        public Personel[] Personels { get; set; }
    }
    public class Muhasebe
    {

        public Şirket[] Şirketler { get; set; }

        public void ListAllPersonelByCID(int id)
        {
            foreach (var şirket in Şirketler)
            {
                if (şirket == null)
                    continue;
                if (şirket.CId == id)
                {
                    foreach (var personel in şirket.Personels)
                    {
                        Console.WriteLine(personel.Ad + "  " + personel.ID);
                    }
                }
            }
        }



        //muhasebe olarak baktığım şirketleri listele
        //şirketlerin adı
        //şirketlerin ıd
        //personel sayılarını göster

        public void ListAllCompany()
        {
            var temp = 1;
            foreach (var item in Şirketler)
            {

                Console.WriteLine(temp + " .şirket adı :" + item.ŞirketAdı + "  cid : " + item.CId + "  personel sayısı " + item.Personels.Length);
                ++temp;
            }

        }

        public void GetTotalSalaryByCID(int id)
        {
            foreach (var şirket in Şirketler)
            {
                if (şirket.CId == id)
                {
                    var temp = 0;

                    foreach (var personel in şirket.Personels )
                    {
                        temp += personel.Maaş;
                    }

                    Console.WriteLine(şirket.ŞirketAdı+" personellerinin aylık maaş toplamı "+temp );
                    break;
                }
            }
        }

    }





}
