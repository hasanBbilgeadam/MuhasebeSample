namespace ConsoleApp7
{
    public class KriptoluYazı
    {
        private string _içerik;
        public string İçerik { 
            get
            {


                return _içerik;
            }
            
            set
            {
                _içerik = BoşlukluYaz(value);
            }

        
        
        }

        private string BoşlukluYaz(string str)
        {
            var temp = "";

            for (int i = 0; i < str.Length; i++)
            {


                temp+= " "+str[i];
            }
            return temp;
        }
            

    }
}
