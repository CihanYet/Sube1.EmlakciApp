using Sube1.EmlakciLib;

namespace Sube1.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Catch NullException
            //try
            //{
            //    Ev evim;//Referans
            //    evim = new Ev();//Ev classından nesne türetildi.
            //    evim.alan = 100;
            //    evim.odasayisi = 2;
            //    evim.katno = 1;
            //    evim.semt = "Gazi";
            //    EvBilgileri(evim);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Bir hata oluştu");
            //} 
            #endregion

            //int sayi = 5;//Set
            //Console.WriteLine(sayi);//Get


            //Ev evim = new Ev();

            //Console.WriteLine("Oda sayısı giriniz:");
            //evim.Odasayisi = int.Parse(Console.ReadLine());


            //Console.WriteLine("Kat no giriniz:");
            //evim.Katno = int.Parse(Console.ReadLine());
            //Console.WriteLine("Semt Giriniz:");
            //evim.SetSemt(Console.ReadLine());
            //Console.WriteLine("Alan giriniz:");
            //evim.SetAlan(double.Parse(Console.ReadLine()));

            //evim.SetAlan(120);
            //Console.WriteLine($"Girilen evin büyüklüğü:{evim.Buyukluk}");



            //var evim = new Ev();

            //evim.SetOdaSayisi(-2);
            //Console.WriteLine(evim.GetOdasayisi());

            //evim.Odasayisi = -2;
            //Console.WriteLine(evim.Odasayisi);

            //evim.SetAlan(90);
            //evim.Alan = 90;
            //Console.WriteLine(evim.Buyukluk);


            var evim = new Ev(2, 3, "Kazan", 100);
            Console.WriteLine(evim.EvBilgileri());

            var evim2 = new Ev(2, 2, 100);
            Console.WriteLine(evim2.EvBilgileri());
            //Ev.Sayac = 10;
            Console.WriteLine($"Ev sayısı:{Ev.Sayac}");

            //<100 Küçük ev
            //100-150 Orta Ev
            //>150 Büyük Ev
        }
    }
}

//Kapsülleme ilkesi(Encapsulation): Bir class içerisinde yapılan işlemlerin, class dışından gizlenmesidir.

//Property: Fieldlara değer atamak yada okumak için kullanılan yapılardır. İçlerinde get ve opsiyonel olarak set yapısı bulunur.

//Classlar aynı zamanda bir veri tipidir.
//Referanslar nesnelere ulaşmak için kullanılan yapılardır. Stack bölgesinde tutulurlar. Heap bölgesinde oluşturulan nesnenin adres bilgisini tutarlar.
//Bir classtan nesne oluşturulduğunda, class içindeki fieldlara varsayılan değerleri atanır.
//private olarak tanımlanan üyelere, class dışından erişilemez.
//public olarak tanımlanan üyelere class dışından erişilebilir.
//Write Once Use Everywhere!
//OOP: Object Oriented Programming
//Class içerisinde static olarak tanımlanan üyeler, class'a ait olurlar ve bu üyelere class adı ile erişilebilir.
//Static olmayan üyeler ise nesneye aittir ve nesne referansı ile erişilebilir.

//DRY- Don't Repeat Yourself