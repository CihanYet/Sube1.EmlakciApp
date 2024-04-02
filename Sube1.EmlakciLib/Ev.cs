using System;

namespace Sube1.EmlakciLib
{
    public class Ev
    {
        private int odasayisi;//field
        private int katno;
        private string semt;
        private double alan;
        private string buyukluk;

        public int Katno { get => katno; set => katno = value; }//Property
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }
        public string Buyukluk { get => buyukluk; }
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

        //public void SetOdaSayisi(int odasayisi)
        //{
        //    this.odasayisi = Math.Abs(odasayisi);
        //}

        //public int GetOdasayisi()
        //{
        //    return this.odasayisi;
        //}

        public string EvBilgileri()
        {
            return $"Oda Sayısı:{this.Odasayisi}\nKat No:{this.Katno}\nAlan:{this.alan}\nSemt:{this.semt}";

            #region Try-Catch-NullCheck
            //if (home != null)//Null check
            //{
            //    return $"Oda Sayısı:{home.odasayisi}\nKat No:{home.katno}\nAlan:{home.alan}\nSemt:{home.semt}";
            //}
            //else
            //{
            //    return "Referans Null geldi!";
            //}

            //try
            //{
            //    return $"Oda Sayısı:{home.odasayisi}\nKat No:{home.katno}\nAlan:{home.alan}\nSemt:{home.semt}";
            //}
            //catch (Exception ex)
            //{                
            //    throw;
            //} 
            #endregion
        }
    }
}
