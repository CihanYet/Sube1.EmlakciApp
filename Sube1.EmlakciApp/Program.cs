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

            Ev evim2 = new Ev();
            evim2.alan = 120;
            evim2.katno = 2;
            evim2.semt = "Kazan";
            evim2.odasayisi = 3;

            Console.WriteLine(evim2.EvBilgileri());
        }
    }   
}

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