using System;
using System.Collections.Generic;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {

        }

        public KiralikEv(int odasayisi, int katno, double alan, string semt, double kira, double depozito) : base(odasayisi, katno, semt, alan)
        {
            this.Kira = kira;
            this.Depozito = depozito;

        }

        public double Kira { get; set; }
        public double Depozito { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        //}

        //public override string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        //}
        public override string ToString()
        {
            return $"{base.ToString()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        }
    }
}

//internal: Aynı namespace içinde bulunan classlardan erişilmek istenen üyeler, internal olarak tanımlanır.
//Name Hiding(İsim Gizleme): Türeyen classlarda, base classtaki ile aynı isimli bir üye tanımlanırsa, türeyen class referansı ile base classtaki üyeye artık ulaşılamaz.
