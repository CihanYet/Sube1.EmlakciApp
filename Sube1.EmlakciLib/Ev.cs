using System;

namespace Sube1.EmlakciLib
{
    public class Ev:Object
    {
        private static int sayac = 0;
        //Constructor-Yapıcı Metod-Kurucu metod
        public Ev(int odasayisi, int katno, string semt, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Alan = alan;
            this.SetSemt(semt);
            sayac++;
        }
        public Ev()
        {
            sayac++;
        }

        public Ev(int odasayisi, int katno, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Alan = alan;
            this.SetSemt("Gazi");
            sayac++;
        }

        private int odasayisi;//field

        private string semt;
        private string buyukluk;

        private double alan;

        public double Alan
        {
            get
            {
                return alan;
            }
            set
            {
                alan = value;
                if (this.alan < 100)
                {
                    this.buyukluk = "Küçük Ev";
                }
                else if (this.alan >= 100 && this.alan <= 150)
                {
                    this.buyukluk = "Orta Ev";
                }
                else
                {
                    this.buyukluk = "Büyük Ev";
                }
            }
        }

        public int Katno { get; set; }

        public string Buyukluk { get => buyukluk; }
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }
        public static int Sayac { get => sayac;  }

        public void SetSemt(string semt) => this.semt = semt.ToUpper();

        public string GetSemt() => this.semt;

        public void SetAlan(double alan)
        {
            this.alan = Math.Abs(alan);
            if (this.alan < 100)
            {
                this.buyukluk = "Küçük Ev";
            }
            else if (this.alan >= 100 && this.alan <= 150)
            {
                this.buyukluk = "Orta Ev";
            }
            else
            {
                this.buyukluk = "Büyük Ev";
            }
        }

        public double GetAlan() => this.alan;

        public void SetOdaSayisi(int odasayisi) => this.Odasayisi = Math.Abs(odasayisi);

        public int GetOdasayisi() => odasayisi;

        //public virtual string EvBilgileri()
        //{
        //    return $"Oda Sayısı:{this.Odasayisi}\nKat No:{this.Katno}\nAlan:{this.alan}\nSemt:{this.semt}";

        //    #region Try-Catch-NullCheck
        //    //if (home != null)//Null check
        //    //{
        //    //    return $"Oda Sayısı:{home.odasayisi}\nKat No:{home.katno}\nAlan:{home.alan}\nSemt:{home.semt}";
        //    //}
        //    //else
        //    //{
        //    //    return "Referans Null geldi!";
        //    //}

        //    //try
        //    //{
        //    //    return $"Oda Sayısı:{home.odasayisi}\nKat No:{home.katno}\nAlan:{home.alan}\nSemt:{home.semt}";
        //    //}
        //    //catch (Exception ex)
        //    //{                
        //    //    throw;
        //    //} 
        //    #endregion
        //}

        public override string ToString()
        {
            return $"Oda Sayısı:{this.Odasayisi}\nKat No:{this.Katno}\nAlan:{this.alan}\nSemt:{this.semt}";
        }

        ~Ev()
        {
            sayac--;
        }
    }
}


//Constructor: Class içinde tanımlanan fieldlara varsayılan değer atamalarını sağlayarak kullanıma hazır hale getirir. Bu metodlar geriye bir değer döndürmezler. Geri dönüş tipleri yoktur. İsimleri, class adıyla aynıdır.

//Garbage Collector:İşi bitern nesneleri bellekten Dispose eden yapıdır.