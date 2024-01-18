using System.Collections.Specialized;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ATM
{
    internal class Program
    {
        public static int pass = 1234;
        public static int bakiye = 2500;
        public static bool atmStatus= false;
        static void Main(string[] args)
        {

            AtmStart();
        }



        public static void AtmStart()
        {


            atmStatus = PassControl();
            while (atmStatus)
            {
                ShowMenu();

                switch (SelectOption())
                {
                    case 1:
                        {
                            ParaCekme();
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            ParaEkleme();
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            ParaGonder();
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }

                    case 4:
                        {
                            SifreDegistir();

                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("çıkış yapılıyor ......");
                            Console.WriteLine("kartınızı unutmayınız ......!!");
                            atmStatus = false;
                            break;
                        }
                    default:
                        break;
                }
            }

            if (!atmStatus)
            {
                Console.WriteLine("kartınızı unutmayınız !!!!  oturum kapandı");
            }
        }
        public static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Bir İşlem Seçini 1 ile 5 arasında bir rakam giriniz");
            Console.WriteLine("1- Para Çekme");
            Console.WriteLine("2- Para Yatırma");
            Console.WriteLine("3- Para Gönder");
            Console.WriteLine("4- Şifre Değiştirme");
            Console.WriteLine("5- Atm'den Çıkış yap");

            Console.ForegroundColor = ConsoleColor.White;


        }
        public static int SelectOption()
        {

            var result = int.TryParse(Console.ReadLine(), out int option);
            var control = true;
            while (control)
            {
                if (!result)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("lütfen 1 ile 5 arasında bir sayı girini hatalı veri girişi yaptınız !");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                if (!(option <= 5 && option >= 1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen 1 ile 5 arasında bir sayı giriniz");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                if (result && (option <= 5 && option >= 1))
                {
                    control = false;

                }
            }
            Console.Clear();
            return option;



        }
        public static bool PassControl()
        {

            var count = 3;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Şifrenizi giriniz  : ");
                int.TryParse(Console.ReadLine(), out int userPass);

                if (userPass == pass)
                {
                    return true;
                }
                else
                {
                    --count;
                    Console.WriteLine("Başarısız Giriş Denemesi " + count + " kadar giriş hakkınız kaldı");
                }
            }
            Console.WriteLine("3 kere hatalı giriş yaptınız kartınızı alınız");

            return false;

        }
        public static void ParaCekme()
        {

            while (true)
            {
                Console.WriteLine("Güncel Bakiyeniz : " + bakiye + " çekmek istediğiniz miktari giriniz");
                var miktar = GetData();

                //bakiye kontrolü
                if (miktar > bakiye)
                {
                    Console.WriteLine("yetersiz bakiye !!");
                }
                else
                {
                    //bakiye düşür
                    bakiye -= miktar;
                    Console.WriteLine("İşlem Sonrası Bakiyeniz "+ bakiye);
                    break;
                }
            }
         

        }
        public static void ParaEkleme()
        {
            while (true)
            {
                Console.WriteLine(" eklemek  istediğiniz mikari giriniz 10'un katı olmalı");
                var miktar = GetData();

                if (miktar%10 == 0)
                {
                    Console.WriteLine("işlem öncesi bakiye "+ bakiye);
                    bakiye += miktar;
                    Console.WriteLine("işlem sonrası bakiye "+ bakiye);
                    break;
                }
                else
                {
                    Console.WriteLine("ekleyeceğiniz miktar 10'un katı olmalı 5 tl ve bozuk para kabul edilmiyor ");
                }


            }
        }
        public static void ParaGonder()
        {
            //5 hane hesap no
            //bakiye kontrol

            var control = true;
            while (control)
            {
                Console.WriteLine("alıcı hesap numarasını girini 5 haneli olmalı");
                var hesapNO = GetData();

                if (hesapNO <10000 && hesapNO > 99999)
                {
                    Console.WriteLine("hatalı hesap numarası girişi");
                }
                else
                {
                    var control2 = true;

                    while (control2)
                    {
                        Console.WriteLine("Gönderilecek miktarı giriniz güncel bakiyeniz : " + bakiye);

                        var miktar = GetData();

                        if (miktar > bakiye)
                        {
                            Console.WriteLine("Yetersiz Bakiye ");
                        }
                        else
                        {
                            Console.WriteLine("işlem öncesi bakiye "+ bakiye);
                            bakiye -= miktar;
                            Console.WriteLine("işlem sonrası bakiye "+ bakiye);

                            control2 = false;
                            control = false;
                        }
                    }

                }

            }


        }
        public static void SifreDegistir()
        {
            int i = 0;
            while(i<3)
            {
                Console.WriteLine("Mevcut Şifreinizi giriniz");
                int currentPass = GetData();

                if (currentPass == pass)
                {
                    Console.WriteLine("Yeni şifreinizi giriniz");

                    var newPass = GetData();
                     //şifrenin 4 haneli olması kontrolü!!
                     //önceki şifre mukayese!!
                    pass=newPass;

                    Console.WriteLine("şifre başarılı bir şekilde değiştirildi");
                    i = int.MaxValue;

                }
                else
                {
                    Console.WriteLine("mevcut şifrenizi hatalı girdiniz tekrar giriniz");

                    
                }

                ++i;
            }
            if (i==3)
            {
                atmStatus = false;
                Console.WriteLine("mevcut şifreyi 3 kere hatalı girdin oturum sonlandı!!!!");
            }

        }
        public static int GetData()
        {
            //v.1
            //var control = true;
            //int x =0;
            //while (control)
            //{


            //    Console.Write(" veri girişi : ");
            //    var result = int.TryParse(Console.ReadLine(), out int number);

            //    if (result)
            //    {
            //        x = number;
            //        control = false;

            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı bir formatta veri girişi yaptınız tekrar veri giriniz ");
            //    }
            //}

            //return x;





            //v.2

            var control = true;
            var number = 0;
            while (control)
            {
                try
                {
                    var data = int.Parse(Console.ReadLine());

                    if (data <=0)
                    {
                        Console.WriteLine("0 ve sıfırdan küçük bir değer girilemez");
                    }
                    else { 
                        
                        control = false;
                        number= data;
                    }
                }
                catch 
                {

                    Console.WriteLine("Hatalı bir formatta veri girişi yaptınız tekrar veri giriniz ");
                }
            }
          return number;
           

        }

    }
}
