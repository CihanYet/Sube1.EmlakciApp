using System;

namespace Sube1.EmlakciLib
{
    public class Ev
    {
        public int odasayisi;//field
        public int katno;
        public string semt;
        public double alan;

        public string EvBilgileri()
        {
            return $"Oda Sayısı:{this.odasayisi}\nKat No:{this.katno}\nAlan:{this.alan}\nSemt:{this.semt}";

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
