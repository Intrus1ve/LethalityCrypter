using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Hamburger
    {
        public string MenuAdi { get; set; }
        public decimal MenuFiyat { get; set; }
        public MenuBoy MenuBoy { get; set; }
        public int Adet { get; set; }
        public static List<Hamburger> menuler = new List<Hamburger>
        {
            new Hamburger{ MenuAdi = "Big Chicken Menu", MenuFiyat = 15},
            new Hamburger{ MenuAdi = "Big King Menu", MenuFiyat = 20},
            new Hamburger{ MenuAdi = "Whooper Menu", MenuFiyat = 25},
           
        };

        public override string ToString()
        {
            return MenuAdi;
        }
    }
}
