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
    public partial class frmDilEkle : Form
    {
        public frmDilEkle()
        {
            InitializeComponent();
        }




        

        private void frmDilEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKitapIslemler kitapIslemlerForm = (frmKitapIslemler)Application.OpenForms["frmKitapIslemler"];
            kitapIslemlerForm.cbKitapDil.DataSource = null;
            kitapIslemlerForm.cbKitapDil.Items.Clear();
            kitapIslemlerForm.cbDillerDoldur();
        }
    }
}
