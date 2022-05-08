using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Vize
{
    public partial class frmEmanetArsivi : Form
    {
        public frmEmanetArsivi()
        {
            InitializeComponent();
        }


        public void emanetlerArsivGöster()  //Emanet Arşivini listelemek ve farklı yerlerde kullanmak için metot oluşturduk.
        {
           
        }
        private void frmEmanetArsivi_Load(object sender, EventArgs e)
        {
            emanetlerArsivGöster();
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
           
        }

        private void btnArsivListeYenile_Click(object sender, EventArgs e) 
        {
            emanetlerArsivGöster();   //DataGridViewin yenilenmesi için arşiv listesini gösteren metotu çağırdık.
        }
    }
}
