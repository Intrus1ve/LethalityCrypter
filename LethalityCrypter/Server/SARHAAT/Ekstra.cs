using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
   public  class Ekstra
    {
        public string EkstraAdi { get; set; }
        public decimal Fiyat { get; set; }
        public static List<Ekstra> ekstralar = new List<Ekstra>
        {
            new Ekstra{ EkstraAdi = "Ketçap", Fiyat = 1},
            new Ekstra{ EkstraAdi = "Acı Sos", Fiyat = 1},
            new Ekstra{ EkstraAdi = "Mayonez", Fiyat = 1},
        };

        public override string ToString()
        {
            return EkstraAdi;
        }
    }
}
