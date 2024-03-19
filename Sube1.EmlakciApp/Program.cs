namespace Sube1.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ev evim;//Referans
            //evim = new Ev();//Ev classından nesne türetildi.
            //evim.alan = 100;
            //evim.odasayisi = 2;
            //evim.katno = 1;
            //evim.semt = "Gazi";

            //string bilgi = EvBilgileri(evim);
            //Console.WriteLine(bilgi);

            //Ev evim2 = new Ev();
            //evim2.alan = 120;
            //evim2.katno = 2;
            //evim2.semt = "Kazan";
            //evim2.odasayisi = 3;

            //Console.WriteLine(EvBilgileri(evim2));

            try
            {
                Ev evim3 = null;
                Console.WriteLine(EvBilgileri(evim3));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Referans null geldi!");
            }
            catch(Exception)
            {
                Console.WriteLine("Bilinmeyen Hata!");
            }
        }

        static string EvBilgileri(Ev home)
        {
            //if (home != null)//Null check
            //{
            //    return $"Oda Sayısı:{home.odasayisi}\nKat No:{home.katno}\nAlan:{home.alan}\nSemt:{home.semt}";
            //}
            //else
            //{
            //    return "Referans Null geldi!";
            //}

            //if (home != null)//Null check
            //{
            //    return $"Oda Sayısı:{home.odasayisi}\nKat No:{home.katno}\nAlan:{home.alan}\nSemt:{home.semt}";
            //}
            //else
            //{
            //    throw new NullReferenceException();
            //}

            try
            {
                return $"Oda Sayısı:{home.odasayisi}\nKat No:{home.katno}\nAlan:{home.alan}\nSemt:{home.semt}";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    class Ev
    {
        public int odasayisi;//field
        public int katno;
        public string semt;
        public double alan;
    }
}

//Classlar aynı zamanda bir veri tipidir.
//Referanslar nesnelere ulaşmak için kullanılan yapılardır. Stack bölgesinde tutulurlar. Heap bölgesinde oluşturulan nesnenin adres bilgisini tutarlar.
//Bir classtan nesne oluşturulduğunda, class içindeki fieldlara varsayılan değerleri atanır.
//private olarak tanımlanan üyelere, class dışından erişilemez.
//public olarak tanımlanan üyelere class dışından erişilebilir.