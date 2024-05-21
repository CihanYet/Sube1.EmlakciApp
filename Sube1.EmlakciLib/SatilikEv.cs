using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {

        }

        public SatilikEv(int odasayisi, int katno, string semt, double alan, double satisfiyat)
        {
            base.Odasayisi = odasayisi;
            base.Katno = katno;
            base.SetSemt(semt);
            base.Alan = alan;
            this.Satisfiyat = satisfiyat;
        }
        public double Satisfiyat { get; set; }


        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nSatış Fiyatı:{this.Satisfiyat}";
        //}

        //public override string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nSatış Fiyatı:{this.Satisfiyat}";
        //}

        public override string ToString()
        {
            return $"{base.ToString()}\nSatış Fiyatı:{this.Satisfiyat}";
        }
    }
}
