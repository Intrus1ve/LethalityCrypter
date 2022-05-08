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
    public partial class frmEmanetIslemler : Form
    {
        private object model;

        public frmEmanetIslemler()
        {
            InitializeComponent();
        }



        public void cbKitaplarDoldur()
        {
        }
        public void cbUyelerDoldur()
        {
    
        }

        public void emanetleriGöster()  //Emanetleri listelemek ve farklı yerlerde kullanmak için metot oluşturduk.
        {
            
        }

        private void frmEmanetIslemler_Load(object sender, EventArgs e)
        {
            emanetleriGöster();
            cbKitaplarDoldur();
            cbUyelerDoldur();
        }

        private void btnEmanetOlustur_Click(object sender, EventArgs e) 
        {
            cbEmanetKitaplar.Text = "Kitap Seçin..";
            cbEmanetUyeler.Text = "Üye Seçin..";
            tbEmanetAciklama.Clear();
            dtEmanetTahminiTeslim.Value = DateTime.Now;
        }

        private void btnEmanetYenile_Click(object sender, EventArgs e)
        {
            emanetleriGöster(); 
        }

        private void btnEmanetDüzenle_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmanetDuzenle emanetDuzenleForm = new frmEmanetDuzenle();
                // Tablodan seçilen emanetin bilgilerini Emanet Düzenle formundaki ilgili yerlere dolduruyoruz.
                emanetDuzenleForm.lblEmanetNo.Text = dgvEmanetListe.SelectedRows[0].Cells["No"].Value.ToString();
                emanetDuzenleForm.tbEmanetAciklama.Text = dgvEmanetListe.SelectedRows[0].Cells["EmanetAciklama"].Value.ToString();
                emanetDuzenleForm.dtEmanetTahminiTeslim.Text = dgvEmanetListe.SelectedRows[0].Cells["EmanetAlinicakTarih"].Value.ToString();
                emanetDuzenleForm.verilenEmanetTeslimDurum = dgvEmanetListe.SelectedRows[0].Cells["TeslimDurumu"].Value.ToString();
                emanetDuzenleForm.Show();   // Tanımladığımız "emanetDuzenleForm" nesnemizi .Show() ile ekranda gösteriyoruz.

            }
            catch (Exception)
            {
                MessageBox.Show("Düzenlenicek Kaydı Seçmediniz.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmanetArsiv_Click(object sender, EventArgs e) 
        {
            frmEmanetArsivi emanetArsivForm = new frmEmanetArsivi();
            emanetArsivForm.Show();  
        }
    }
}
