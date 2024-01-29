using System.Globalization;
using System.Text.Json;

namespace ConsoleApp15
{
    internal class Program
    {
        public static string ürünDataPath = "urunler.json";
        public static string userDataPath = "users.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
             
            
              ürün  class    
                prop   Id
                prop   adı
                prop   fiyat
                prop    kategori

            Telefon:Ürün
            Tablet:Ürün
            Masa :ürün



            ÜrünYönetimi 
               amacı : verileri jsonyasında saklamak, oradan okumak
               //sınıf methodlar generic

            t' tiplerine bir şart ekle 
            bu şart t'in bir sınıf olması olsun
              where T: class
            Add(t ) => kendisine gelen veriy,i json'a
            Delete(t ) => kendisine gelen veriyi siliyor

                
                
             
             */

            ÜrünYönetimi ürünYönetimi = new();


            //ürünYönetimi.Add<Telefon>(new Telefon()
            //{
            //    Ad = "s3",
            //    Id = 1,
            //    Fiyat = 100,
            //    Kategori = "mobil"
            //});
            
            //ürünYönetimi.Add<Telefon>(new Telefon()
            //{
            //    Ad = "s4",
            //    Id = 2,
            //    Fiyat = 200,
            //    Kategori = "mobil"
            //});
            
            //ürünYönetimi.Add<Tablet>(new Tablet()
            //{
            //    Ad = "t1",
            //    Id = 3,
            //    Fiyat = 300,
            //    Kategori = "tablet"
            //});

            ürünYönetimi.List();




        }

        public interface Iürün { }
        public class Ürün:Iürün
        {
            public int Id { get; set; }
            public int Fiyat { get; set; }
            public string Ad { get; set; }
            public string Kategori { get; set; }
        }
        public class Telefon : Ürün { }
        public class Tablet :Ürün{  }
        public class Masa :Ürün{  }


        public class User
        {
            public int Id { get; set; }
            public string UserName { get; set; }

        }
        public class KullanıcıYönetimi
        {

            public void Add(User t)
            {
                File.ReadAllText(Program.userDataPath);

            }
        }
        public class ÜrünYönetimi
        {

            public void Add<T>(T item) where T:class,Iürün
            {
                var oldData=  File.ReadAllText(Program.ürünDataPath);
                List<T> list = new List<T>();   
                if (oldData!=string.Empty)
                {
                    var data= JsonSerializer.Deserialize<List<T>>(oldData);

                    list.AddRange(data);

                    
                }
                list.Add(item);

                var newJsonData = JsonSerializer.Serialize(list);

                File.WriteAllText(Program.ürünDataPath,newJsonData);
            }


            public void List()
            {
                var oldData = File.ReadAllText(Program.ürünDataPath);

                if (oldData != string.Empty)
                {
                    var data = JsonSerializer.Deserialize<List<Ürün>>(oldData);
                    foreach (var item in data)
                    {
                        Console.WriteLine();
                        Console.WriteLine(item.Id);
                        Console.WriteLine(item.Ad);
                        Console.WriteLine(item.Kategori);
                        Console.WriteLine("---------------");
    
                    }
                }
                else
                {
                    Console.WriteLine("data yok");
                }

            }

        }

        //kullanıcı yönetimi sınıfı
        //kullanıcı ekle
        //listele

        
    }
}
