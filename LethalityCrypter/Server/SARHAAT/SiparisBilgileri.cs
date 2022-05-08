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
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            lblCiro.Text = Siparis.Ciro.ToString();
            lblSiparisSayisi.Text = Siparis.ToplamSiparisSayisi.ToString();
            label1.Text = Siparis.EkstraMalzemeGeliri.ToString();
        }
    }
}
