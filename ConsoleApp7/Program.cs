using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Günlük günlük = new Günlük();
            Random random = new Random();

            var control = true;
            while (control)
            {

                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("bir işlem seçiniz");
                Console.WriteLine("1- ekle 2- sil 3- ara 4- listele");
                var işlem = int.Parse(Console.ReadLine());
                switch (işlem)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("gün yazını yaz");
                            var data = Console.ReadLine();

                            var data2 = new GünlükYazılar(random.Next(20, 200000), data);

                            günlük.Ekle(data2);

                            Console.WriteLine();
                            Console.WriteLine("günlük eklendi ana menüye dönüyorsun");
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("silmek istediğin id ver");


                            var id = int.Parse(Console.ReadLine());
                            günlük.Sil(id);
                            Console.WriteLine("günlük silindi");
                            Console.WriteLine("ana menüye dönüyorsun");
                            Console.WriteLine();
                            break;
                        }

                    case 3:
                        {
                            var id = int.Parse(Console.ReadLine());
                            günlük.IdBilgisineGöreGetir(id);
                            Console.WriteLine("ana menüye dönüyorsun");
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {

                            günlük.Listele();
                            Console.WriteLine("ana menüye dönüyorsun");
                            Console.WriteLine();
                            break;

                        }
                    default:
                        control = false;
                        break;
                }

            }

        }



    }



    public class Günlük
    {

        private GünlükYazılar[] _arr;
        private int _count = 0;
        public int MevcutGünlükAdet { get { return _count; } }

        public void Ekle(GünlükYazılar yazı)
        {

            var newArr = new GünlükYazılar[_count + 1];

            for (int i = 0; i < _count; i++)
            {
                newArr[i] = _arr[i];
            }
            ++_count;
            newArr[_count - 1] = yazı;
            _arr = newArr;
        }
        public void Listele()
        {

            foreach (var item in _arr)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("id : " + item.Id);
                Console.WriteLine("tarih : " + item.OluşturmaTarihi.ToString());
                Console.WriteLine("içerik : " + item.İçerik);
                Console.WriteLine("---------------------------");

                Console.WriteLine();

            }
        }


        public void Sil(int id)
        {

            if (_count == 0)
            {
                Console.WriteLine("eleman yok");
                return;
            }
            var newArr = new GünlükYazılar[_count - 1];


            for (int i = 0, j = 0; i < _count - 1; i++, j++)
            {
                if (_arr[i].Id != id)
                {
                    newArr[i] = _arr[j];
                }

                else
                {
                    newArr[i] = _arr[j + 1];
                    j++;
                }


            }

            _arr = newArr;
            --_count;
        }


        public void IdBilgisineGöreGetir(int id)
        {
            foreach (var item in _arr)
            {
                if (item.Id == id)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.İçerik);
                    Console.WriteLine(item.OluşturmaTarihi);
                    Console.WriteLine("---------------");
                    return;
                }
            }
        }
    }
}
