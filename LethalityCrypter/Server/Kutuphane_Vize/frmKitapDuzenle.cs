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
    public partial class frmKitapDuzenle : Form
    {
        public frmKitapDuzenle()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model2 = new Kutuphane_VizeEntities1();

        public string yazarGelenAd { get; set; }
        public string turGelenAd { get; set; }
        public string yayineviGelenAd { get; set; }
        public string dilGelenAd { get; set; }


        public void cbYazarlarDoldur2()
        {
            
        }

        public void cbTurlerDoldur2()
        {
          

        }
        public void cbYayineviDoldur2()
        {
            
        }
        public void cbDillerDoldur2()
        {
            
        }

        private void btnKitapGüncelle_Click(object sender, EventArgs e)  //Kitap Güncelleme Butonu Tıklandığında
        {
            try 
            {
            int kitapNo = Convert.ToInt32(lblKitapNo.Text);     
  
         
      
            MessageBox.Show("Kitap kaydı başarıyla güncellendi.",
            ""
            , MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();   //İşlem bittiginde form ekranını kapadık.
            }
            catch (Exception)
            {
                MessageBox.Show("Kitap kaydı güncellenirken hata oluştu. Bilgileri kontol ediniz",
                 ""
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKitapDuzenle_Load(object sender, EventArgs e)
        {
            cbYazarlarDoldur2();
            cbTurlerDoldur2();
            cbYayineviDoldur2();
            cbDillerDoldur2();

        }

        private void frmKitapDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKitapIslemler kitapIslemlerForm = (frmKitapIslemler)Application.OpenForms["frmKitapIslemler"];
            kitapIslemlerForm.kitaplariGöster();
        }
    }
}
