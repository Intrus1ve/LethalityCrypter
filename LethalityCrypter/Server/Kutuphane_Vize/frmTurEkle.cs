using AzdımLan;
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
    public partial class frmTurEkle : Form
    {
        public frmTurEkle()
        {
            InitializeComponent();
        }



        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            try
            {
               
               
                tbTurAd.Clear();    
                MessageBox.Show("Tür Eklendi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Tür Eklenemedi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmTurEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKitapIslemler kitapIslemlerForm = (frmKitapIslemler)Application.OpenForms["frmKitapIslemler"];
            kitapIslemlerForm.cbKitapTur.DataSource = null;
            kitapIslemlerForm.cbKitapTur.Items.Clear();
            kitapIslemlerForm.cbTurlerDoldur();
        }
    }
}
