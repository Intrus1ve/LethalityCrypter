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
    public partial class frmUyeIslemler : Form
    {
        public frmUyeIslemler()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1();
        public void uyeleriGöster() //Üyeleri listelemek ve farklı yerlerde kullanmak için metot oluşturduk.
        {
        }

        public void cbOkullarDoldur()
        {
            
        }

        private void frmUyeIslemler_Load(object sender, EventArgs e)
        {
            uyeleriGöster();
            cbOkullarDoldur();
        }

        private void btnOkulEkleForm_Click(object sender, EventArgs e)
        {
            frmOkulEkle okulEkleForm = new frmOkulEkle(); 
            okulEkleForm.Show(); 
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)  
        {
             
           
         
            uyeleriGöster();     
            tbUyeAd.Clear();    
            tbUyeSoyad.Clear();
            tbUyeTelefon.Clear();
            tbUyeMail.Clear();
            tbUyeAdres.Clear();
        }

        private void btnUyeYenile_Click(object sender, EventArgs e) 
        {
            uyeleriGöster(); 
        }


        int id = 0;
        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvUyeListe.SelectedRows[0].Cells["No"].Value.ToString()); 
              
                MessageBox.Show("Üye kaydı başarıyla silindi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                uyeleriGöster();   //Silinen kayıt sonrası tabloyu yeniliyoruz.
            }
            catch (Exception)
            {
                MessageBox.Show("Silinicek Kaydı Seçmediniz.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUyeDüzenle_Click(object sender, EventArgs e) 
        {
            try
            {
                frmUyeDuzenle frmUyeDüzen = new frmUyeDuzenle();   
                frmUyeDüzen.lblUyeNo.Text = dgvUyeListe.SelectedRows[0].Cells["No"].Value.ToString();       
                frmUyeDüzen.tbUyeAd.Text = dgvUyeListe.SelectedRows[0].Cells["UyeAd"].Value.ToString();     
                frmUyeDüzen.tbUyeSoyad.Text = dgvUyeListe.SelectedRows[0].Cells["UyeSoyad"].Value.ToString();
                frmUyeDüzen.tbUyeTelefon.Text = dgvUyeListe.SelectedRows[0].Cells["UyeTelefon"].Value.ToString();
                frmUyeDüzen.tbUyeMail.Text = dgvUyeListe.SelectedRows[0].Cells["UyeEposta"].Value.ToString();
                frmUyeDüzen.tbUyeAdres.Text = dgvUyeListe.SelectedRows[0].Cells["UyeAdres"].Value.ToString();
                frmUyeDüzen.okulGelenAd = dgvUyeListe.SelectedRows[0].Cells["UyeOkul"].Value.ToString();
                frmUyeDüzen.Show();  // Tanımladığımız "frmUyeDüzen" nesnemizi .Show() ile ekranda gösteriyoruz.
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
    }
}
