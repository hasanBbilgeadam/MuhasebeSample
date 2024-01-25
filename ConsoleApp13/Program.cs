using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace ConsoleApp13
{
    internal class Program
    {
        static async Task Main(string[] args)
        {


              
            PersonelControl pc = new PersonelControl();



            pc.PersonelListele();

            await Console.Out.WriteLineAsync("--------------------------");
            pc.PersonelSil(5);
            await Console.Out.WriteLineAsync("--------SİLME SONRASI ----------");
            await Console.Out.WriteLineAsync(" ");
            pc.PersonelListele();





        }
    }


    public class PersonelControl
    {
        public void PersoneEkle(Personel p)
        {

            var data = File.ReadAllText("data2.txt");

            if (data == string.Empty)
            {

                var arr = new Personel[1];

                arr[0] = p;

                File.WriteAllText( "data2.txt",JsonSerializer.Serialize(arr));



                return;
            }
            var oldList =  JsonSerializer.Deserialize<Personel[]>(data);

            var newList = new Personel[oldList.Length + 1];

            for (int i = 0;i<oldList.Length;i++)
                newList[i] = oldList[i];

            newList[newList.Length-1] = p;


            var allData  =JsonSerializer.Serialize(newList);

            File.WriteAllText("data2.txt",allData);




        }

        public void PersonelSil(int id)
        {
            var data = File.ReadAllText("data2.txt");

            if (data == string.Empty)
            {
                Console.WriteLine("zaten kayıt yok");
                return;
            }

            var oldList = JsonSerializer.Deserialize<Personel[]>(data);

            var control = false;
            foreach (var item in oldList)
            {
                if (item.Id==id)
                {
                    control = true;
                }

            }
            if(!control)
            {
                Console.WriteLine("böyle bir kullanıcı yok");
                return;
            }
            var newList = new Personel[oldList.Length - 1];

            for (int i = 0,j=0; i < oldList.Length; i++)
            {

                if (oldList[i].Id != id)
                {
                    newList[j] = oldList[i];
                    j++;
                }
                
            }


             var result =  JsonSerializer.Serialize(newList);

            File.WriteAllText("data2.txt",result);

        }



        public void PersonelListele()
        {
            var data = JsonSerializer.Deserialize<Personel[]>(File.ReadAllText("data2.txt"));


            foreach (var item in data)
            {
                Console.WriteLine(item.Id + "   "+ item.Name+" ");
            }
        }
    } 
    public class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Salary { get; set; }
    }
    public class Kitap
    {

        public int ISBN { get; set; }
        public string Yazar { get; set; }
        public int BasımYılı { get; set; }
        public string KitapAdı { get; set; }
    }
}
