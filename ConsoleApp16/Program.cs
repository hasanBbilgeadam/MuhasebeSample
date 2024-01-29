using System.Text.Json;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var userRepo = new Repository<User>("user.json");
            var productRepo = new Repository<Ürün>("product.json");

            userRepo.Add(new User() { Id = 1, UserName = "asd" });
            productRepo.Add(new Masa() { Id = 31, Fiyat = 21, Marka = "boş" });



        }
    }
    public interface IEntity
    {
        public int Id { get; set; }
    }

    public class Ürün:IEntity
    {
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public int Id { get; set; }
    }
    public class Masa:Ürün
    {

    }
    public class User:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }

    }

    public class Repository<T> where T:class,IEntity
    {
        private string _path;
        public Repository(string path)
        {
                _path = path;

            if (!File.Exists(path))
            {
                File.Create(path);
                
            }
        }

        public void Add(T item)
        {
            var oldData = File.ReadAllText(_path);

            List<T> list = new List<T>();
            if (oldData !=string.Empty) {
                
              var oldDataList =  JsonSerializer.Deserialize<List<T>>(oldData);

                list.AddRange(oldDataList);
                list.Add(item);
            }
            else
            {
                list.Add(item);

            }

           File.WriteAllText(_path, JsonSerializer.Serialize(list));

        }

        
    }
}
