namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            
            DinamikVeriDeposu dinamikVeriDeposu = new();

            Console.WriteLine("başlangıc"+ dinamikVeriDeposu.Count);

            dinamikVeriDeposu.Add("asdasd");
         
            for (int i = 0; i < 1000; i++)
            {
                dinamikVeriDeposu.Add("test "+i);
            }

            Console.WriteLine();

            dinamikVeriDeposu.ListAllItem();

        }

    }

    //string
    public class DinamikVeriDeposu
    {
        private string [] _arr;
        private int _count=0;


        public int Count { get { return _count; } }
        public void Add(string data)
        {
            var newArr = new string[_count+1];
           

            for (int i = 0; i < _count; i++)
            {
                newArr[i]   = _arr[i];

            }
            
            ++_count;
            newArr[_count - 1] = data;

            _arr = newArr;


        }

        public void ListAllItem()
        {
            foreach (var item in _arr)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
        }
    }
}
