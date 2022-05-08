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
    public partial class frmKitapIslemler : Form
    {
        public frmKitapIslemler()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1(); 
        public void kitaplariGöster()   // Kitapları göstermek ve diğer formlarda kullanabilmek için public metot oluşturuyoruz.
        {
           
        }
        public void cbYazarlarDoldur() // Yazarları Comboboxa doldurmak ve diğer formlarda kullanabilmek için public metot oluşturuyoruz.
        {
     
        }
        public void cbTurlerDoldur()
        {
            
        }
        public void cbYayineviDoldur()
        {
           
        }
        public void cbDillerDoldur()
        {
        }
        private void frmKitapIslemler_Load(object sender, EventArgs e)
        {
            kitaplariGöster();
            cbYazarlarDoldur();
            cbTurlerDoldur();
            cbYayineviDoldur();
            cbDillerDoldur();
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
           
            
            kitaplariGöster();      //Eklenen kayıt sonrası kaydın görünmesi adına tabloyu yeniliyoruz.

            tbKitapBaskiYil.Clear();    //Son olarak girilen bilgilerin textboxlarını boşaltıyoruz.
            tbKitapSayfaSayi.Clear();
            tbKitapAd.Clear();
            tbKitapAciklama.Clear();
        }
        private void btnKitapDüzenle_Click(object sender, EventArgs e)
        {
            try
            {
            frmKitapDuzenle frmKitapDüzen = new frmKitapDuzenle();   
            frmKitapDüzen.lblKitapNo.Text = dgvKitapListe.SelectedRows[0].Cells["No"].Value.ToString();
            frmKitapDüzen.tbKitapAd.Text = dgvKitapListe.SelectedRows[0].Cells["KitapAd"].Value.ToString(); 
            frmKitapDüzen.tbKitapBaskiYil.Text = dgvKitapListe.SelectedRows[0].Cells["BaskıYıl"].Value.ToString();
            frmKitapDüzen.tbKitapSayfaSayi.Text = dgvKitapListe.SelectedRows[0].Cells["SayfaSayısı"].Value.ToString();
            frmKitapDüzen.tbKitapAciklama.Text = dgvKitapListe.SelectedRows[0].Cells["Açıklama"].Value.ToString();
            frmKitapDüzen.yazarGelenAd = dgvKitapListe.SelectedRows[0].Cells["Yazar"].Value.ToString();       
            frmKitapDüzen.yayineviGelenAd = dgvKitapListe.SelectedRows[0].Cells["YayınEvi"].Value.ToString(); 
            frmKitapDüzen.dilGelenAd = dgvKitapListe.SelectedRows[0].Cells["Dil"].Value.ToString();
            frmKitapDüzen.turGelenAd = dgvKitapListe.SelectedRows[0].Cells["Tür"].Value.ToString();
            frmKitapDüzen.Show();  // Tanımladığımız "frmKitapDüzen" nesnemizi .Show() ile ekranda gösteriyoruz.
            }
            catch (Exception)
            {
                MessageBox.Show("Düzenlenicek Kaydı Seçmediniz.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int id = 0;
        private void btnKitapSil_Click(object sender, EventArgs e)      
        {
            try
            {
          

                MessageBox.Show("Kitap kaydı başarıyla silindi.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kitaplariGöster();   //Silinen kayıt sonrası tabloyu yeniliyoruz.
            }
            catch (Exception)
            {
                MessageBox.Show("Silinicek Kaydı Seçmediniz.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKitapYenile_Click(object sender, EventArgs e)
        {
            kitaplariGöster();      //Kitapları doldurmak için tanımladığımız metotu çağırıyoruz.
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
           
        }
        private void btnYazarEkleForm_Click(object sender, EventArgs e)
        {
            frmYazarEkle yazarEkleForm = new frmYazarEkle(); 
            yazarEkleForm.Show();  
        }
        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            frmTurEkle turEkleForm = new frmTurEkle(); 
            turEkleForm.Show();  
        }
        private void btnYayineviEkle_Click(object sender, EventArgs e)
        {
            frmYayineviEkle yayineviEkleForm = new frmYayineviEkle();
            yayineviEkleForm.Show();  
        }
        private void btnDilEkle_Click(object sender, EventArgs e)
        {
            frmDilEkle dilEkleForm = new frmDilEkle(); 
            dilEkleForm.Show();   
        }
    }
}
