using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerOtomasyonu
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hamburger menu = new Hamburger();

            menu.MenuAdi = txtMenu.Text;
            menu.MenuFiyat = nudFiyat.Value;

            Hamburger.menuler.Add(menu);

            txtMenu.Text = "";
            nudFiyat.Value = 0;
        }
    }
}
