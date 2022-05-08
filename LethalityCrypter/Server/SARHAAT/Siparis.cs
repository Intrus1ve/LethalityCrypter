using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
   public class Siparis
    {

        public Hamburger Menu { get; set; }
        public MenuBoy MenuBoy { get; set; }
        public static decimal Ciro { get; set; }
        public static decimal EkstraMalzemeGeliri { get; set; }
        public static List<Ekstra> ekstralar = new List<Ekstra>();
        public static int ToplamSiparisSayisi { get; set; }
        public static List<Siparis> siparisler = new List<Siparis>();
    }
}
