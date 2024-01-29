using System.Diagnostics;

namespace ConsoleApp14
{
    internal class Program
    {

          
        static void Main(string[] args)
        {

            /*
             
                private T[] arr  1

               T[] neewarr = new T[ arr.leng+1]
            newarr = arr
                
            add  1 1
            add   2
             
             */

            /*
            
            private arr
            arka planın bir array saklıyor
            eleman ekledikçe büyüyor boyutu
            eski elemanları koruyarak


             
             custom bir list sınıfı
             CustomList<T>  generic bir sınıf   
            bir list implementeasyonu
                içersinde add..(..)  => generic
                delete...(...)  => generic
                
                ListAll()=> tüm datayı yazdıracak
                count => property mevcut eleman saysını gösterecek
                LastItem prop generic => en son eklenen elemanı tutacak

             
             
             
             */

            MyCustomList<int> list = new();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.WriteLine("silme öncesi");

            list.ListAll(); 
            
            Console.WriteLine("last item "+list.LastItem);
            Console.WriteLine("-----------");
            
            list.Delete(3);
            Console.WriteLine("silme sonrası");
            list.ListAll(); 
        }

      
      
        
    }

   
    public class MyCustomList<T> where T :struct
    {

        private T[] arr;
        private int _count = 0;
        private T _LastItem;
        public T LastItem { get { return _LastItem; }  }

        public MyCustomList()
        {
            arr = new T[_count];
        }
        public void Add(T item) {
        
            var newArr= new T[_count+1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length-1] = item;
             
            arr= newArr;    
            _LastItem = item;   
            _count++;   

        }

        public void Delete(T item)
        {

            var newArr= new T[_count-1];


            for (int i = 0,j=0; i < arr.Length-1; i++,j++)
            {
                if (Comparer<T>.Default.Compare(arr[i], item) != 0)
                {
                   

                    newArr[i] = arr[j];
                
                }
                else
                {
                    newArr[i] = arr[j + 1];
                    j++;
                }
              

            }


            arr = newArr;
            _LastItem = arr[arr.Length - 1];
            --_count;
        }


        public void ListAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }

}
